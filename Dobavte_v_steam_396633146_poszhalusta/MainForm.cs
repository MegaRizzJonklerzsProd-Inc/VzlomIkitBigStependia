using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dobavte_v_steam_396633146_poszhalusta
{
    public partial class MainForm : Form
    {
        private List<Planet> planets = new List<Planet>();
        private Timer timer;
        private Random random = new Random();
        private bool isDrawingTrajectory = false;

        public MainForm()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, panel, new object[] { true });

            timer = new Timer();
            timer.Interval = 30; // интервал обновления (мс)
            timer.Tick += Timer_Tick;

        }

        // Расчет расстояния между двумя планетами
        private double Distance(double x1, double y1, double x2, double y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        // Расчет сил для всех планет
        private void CalculateForces()
        {
            const double G = 10;
            // обнуляем силы
            foreach (var p in planets)
            {
                p.fx = 0;
                p.fy = 0;
            }
            // гравитационные взаимодействия
            for (int i = 0; i < planets.Count; i++)
            {
                for (int j = i + 1; j < planets.Count; j++)
                {
                    var p1 = planets[i];
                    var p2 = planets[j];

                    double dx = p2.x - p1.x;
                    double dy = p2.y - p1.y;
                    double dist2 = dx * dx + dy * dy;
                    double distance = Math.Sqrt(dist2);
                    if (dist2 < 1e-2) // избегаем деления на ноль
                        continue;

                    double force = G * p1.m * p2.m / dist2;
                    double fx = force * dx / distance;
                    double fy = force * dy / distance;

                    p1.fx += fx;
                    p1.fy += fy;
                    p2.fx -= fx;
                    p2.fy -= fy;
                }
            }
        }

        // Обновление позиций и скоростей
        private void UpdatePositions()
        {
            double dt = 0.1;
            double damping = 0.999; // эффект сопротивления, чтобы всё не разлеталось бесконечно

            // обновляем скорости и позиции
            foreach (var p in planets)
            {
                p.vx = (p.vx + p.fx / p.m * dt) * damping;
                p.vy = (p.vy + p.fy / p.m * dt) * damping;

                p.x += p.vx * dt;
                p.y += p.vy * dt;

                // границы окна
                if (p.x < 0 || p.x > panel.Width)
                {
                    p.vx *= -0.5;
                    p.x = p.x < 0 ? 0 : Math.Min(p.x, panel.Width);
                }
                if (p.y < 0 || p.y > panel.Height)
                {
                    p.vy *= -0.5;
                    p.y = p.y < 0 ? 0 : Math.Min(p.y, panel.Height);
                }
            }

            // не даёт планетам пересекаться
            for (int i = 0; i < planets.Count; i++)
            {
                for (int j = i + 1; j < planets.Count; j++)
                {
                    var p1 = planets[i];
                    var p2 = planets[j];
                    double dx = p2.x - p1.x;
                    double dy = p2.y - p1.y;
                    double distance = Math.Sqrt(dx * dx + dy * dy);
                    double minDist = p1.radius + p2.radius;

                    // дистанция между планетами
                    if (distance < minDist && distance > 0)
                    {
                        double overlap = minDist - distance;
                        double nx = dx / distance;
                        double ny = dy / distance;

                        // раздвигаем поровну
                        p1.x -= nx * overlap / 2;
                        p1.y -= ny * overlap / 2;
                        p2.x += nx * overlap / 2;
                        p2.y += ny * overlap / 2;
                    }
                }
            }

            // обновляем траектории
            foreach (var p in planets)
            {
                p.trajectory.Add(new PointF((float)p.x, (float)p.y));
            }
        }

        // Отрисовка планет
        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (var planet in planets)
            {
                int r = planet.radius;
                SolidBrush brush = null;
                try
                {
                    brush = new SolidBrush(planet.color);
                    g.FillEllipse(brush, (float)(planet.x - r), (float)(planet.y - r), r * 2, r * 2);
                }
                finally
                {
                    if (brush != null)
                        brush.Dispose();
                }

                if (isDrawingTrajectory && planet.trajectory.Count > 1)
                {
                    Pen pen = null;
                    try
                    {
                        pen = new Pen(planet.color, 1);
                        g.DrawLines(pen, planet.trajectory.ToArray());
                    }
                    finally
                    {
                        if (pen != null)
                            pen.Dispose();
                    }
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            CalculateForces();
            UpdatePositions();
            panel.Invalidate();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (NumberOfPlanets.Text != "")
            {
                string s = NumberOfPlanets.Text;
                if (Int32.TryParse(s, out int s1)){
                    InitializeValues(s1);
                    panel.Invalidate();
                }
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer.Start();
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (planets.Count != 0)
            {
                SettingsForm settingsForm = new SettingsForm(planets);
                if (settingsForm.ShowDialog() == DialogResult.OK)
                    settingsForm.Invalidate();
                settingsForm.Dispose();
            }
        }

        private void checkBoxTrajectory_CheckedChanged(object sender, EventArgs e)
        {
            isDrawingTrajectory = checkBoxTrajectory.Checked;
            panel.Invalidate();
        }

        private void InitializeValues(int bodyCount)
        {
            planets.Clear();

            int padding = 0;
            for (int i = 0; i < bodyCount; i++)
            {
                var p = new Planet()
                {
                    m = random.Next(1, 6),
                    x = random.Next(padding, panel.Width - padding),
                    y = random.Next(padding, panel.Height - padding),
                    vx = Convert.ToDouble((random.NextDouble() * 2 - 1).ToString("F5")),
                    vy = Convert.ToDouble((random.NextDouble() * 2 - 1).ToString("F5")),
                    color = Color.FromArgb(50 + random.Next(206), 50 + random.Next(206), 50 + random.Next(206))
                };
                p.trajectory.Add(new PointF((float)p.x, (float)p.y));
                planets.Add(p);
            }

        }
    }
}
