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
            this.firstPoint = firstPoint;
            this.secondPoint = secondPoint;
        }

        public XY DoIntersect(LineSegment secondLineSegment)//implement checking mechanism for commonpoint is on the linesegments or not
        {

            XY commonPoint = new XY(0, 0);
            Line firstLine = new Line(firstPoint, secondPoint);
            Line secondLine = new Line(secondLineSegment.firstPoint, secondLineSegment.secondPoint);

            commonPoint = firstLine.DoIntersect(secondLine);

            return commonPoint;
        }

    /*    public LineSegment(double slope, double offset) : base(slope, offset)
        {

        }
        */

    }
}
