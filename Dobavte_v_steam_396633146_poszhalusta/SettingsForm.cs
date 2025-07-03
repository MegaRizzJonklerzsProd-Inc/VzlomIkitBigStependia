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
    public partial class SettingsForm : Form
    {
        public List<Planet> Planets { get; private set; }
        private List<TextBox[]> inputControls = new List<TextBox[]>();

        public SettingsForm(List<Planet> planets)
        {
            InitializeComponent();
            Planets = planets;
            // Заполнение текстовых полей данными из planets
            for (int i = 1; i <= Planets.Count; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(comboBox1.Text);
            PlanetMass.Text = Planets[s - 1].m.ToString();
            CoordinateX.Text = Planets[s - 1].x.ToString();
            CoordinateY.Text = Planets[s - 1].y.ToString();
            SpeedX.Text = Planets[s - 1].vx.ToString();
            SpeedY.Text = Planets[s - 1].vy.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(comboBox1.Text);
            Planets[s - 1].m = Convert.ToDouble(PlanetMass.Text); ;
            Planets[s - 1].x = Convert.ToDouble(CoordinateX.Text);
            Planets[s - 1].y = Convert.ToDouble(CoordinateY.Text);
            Planets[s - 1].vx = Convert.ToDouble(SpeedX.Text);
            Planets[s - 1].vy = Convert.ToDouble(SpeedY.Text);
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
