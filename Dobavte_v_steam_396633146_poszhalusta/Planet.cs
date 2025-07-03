using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dobavte_v_steam_396633146_poszhalusta
{
    public class Planet
    {
        public double m { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        public double vx { get; set; }
        public double vy { get; set; }
        public double fx { get; set; }
        public double fy { get; set; }

        public List<PointF> trajectory { get; } = new List<PointF>();
        public Color color {  get; set; }
        public int radius => 4 + (int)Math.Sqrt(m*2);
    }
}
