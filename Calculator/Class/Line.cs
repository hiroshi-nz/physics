using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
 Always make sure noSlope is false! 
 */
namespace Calculator.Class
{
    class Line
    {
        public bool noSlope = false;
        public bool xConstant = false;
        public bool yConstant = false;
        public double slope = 0;
        public double offset = 0;
        public double x = 0;
        public double y = 0;

        public Line(XY firstPoint, XY secondPoint)
        {
            if (firstPoint != secondPoint)//not same point
            {
                if (firstPoint.x == secondPoint.x)
                {
                    x = firstPoint.x;//x is always this value
                    noSlope = true;
                    xConstant = true;
                }
                else if (firstPoint.y == secondPoint.y)//
                {
                    y = firstPoint.y;//y is always this value
                    noSlope = true;
                    yConstant = true;
                }
                else
                {
                    double xDiff = firstPoint.x - secondPoint.x;
                    double yDiff = firstPoint.y - secondPoint.y;
                    slope = yDiff / xDiff;
                    offset = slope * - firstPoint.x + firstPoint.y;              
                }
            }
        }

        public double GetX(double y)// return -1 when y is constant.
        {
            double x = -1;

            if (noSlope == false)
            {
                x = (y - offset) / slope;
            }
            else if(xConstant == true)
            {
                x = this.x;
            }
            else if(yConstant == true)
            {
                //y is constant which means there is no solution.
            }
            return x;
        }

        public double GetY(double x)// return -1 when x is constant.
        {
            double y = -1;

            if (noSlope == false)
            {
                y = slope * x + offset;
            }
            else if (xConstant == true)
            {
                //x is constant which means there is no solution.
            }
            else if (yConstant == true)
            {                
                y = this.y;
            }
            return y;
        }

    }
}
