using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Class
{
    //explanation of inheritance
    //https://msdn.microsoft.com/en-us/library/ms228387(v=vs.90).aspx
    class LineSegment : Line
    {

        public XY firstPoint;
        public XY secondPoint;

        public LineSegment(XY firstPoint, XY secondPoint) : base(firstPoint, secondPoint)
        {

        }

        public LineSegment(double slope, double offset) : base(slope, offset)
        {

        }

    }
}
