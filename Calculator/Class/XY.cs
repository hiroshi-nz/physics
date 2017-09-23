using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Class
{
    class XY
    {
        public double x { get; set; }
        public double y { get; set; }

        public XY(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Add(XY xy)
        {
            this.x += xy.x;
            this.y += xy.y;
        }
    }
}
