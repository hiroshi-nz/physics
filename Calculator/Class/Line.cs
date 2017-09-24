using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
 Always make sure noSlope is false! 

I need to implement DoIntersect for when lines are horizontal or vertical.
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
        public double x = 0;//only used when x is constant.
        public double y = 0;//only used when y is constant.

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

        public Line(double slope, double offset)
        {
            this.slope = slope;
            this.offset = offset;
        }

        public Line(bool xConstant, bool yConstant, double constantValue)//constructor for when x or y is constant(slope is zero).
        {
            if (xConstant)
            {
                this.xConstant = true;
                x = constantValue;
            }
            else if(yConstant)
            {
                this.yConstant = true;
                y = constantValue;
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

        public XY DoIntersect(Line secondLine)// I only implemented for lines with slopes, so I need to work on this later for horizontal and vertical lines.
        {
            XY commonPoint = new XY(0, 0);

            if (noSlope == false)
            {
                if (secondLine.noSlope == false)//both of them has slope
                {
                    double a = - slope * secondLine.offset / secondLine.slope + offset;
                    double b = 1 - slope / secondLine.slope;
                    commonPoint.y = a / b;
                    commonPoint.x = commonPoint.y - offset / slope;
                }
                else if (secondLine.xConstant == true)
                {

                }
                else if (secondLine.yConstant == true)
                {

                }


            }
            else if (xConstant == true)
            {
                if (secondLine.noSlope == false)
                {

                }
                else if (secondLine.xConstant == true)//Parallel
                {

                }
                else if (secondLine.yConstant == true)
                {

                }
            }
            else if (yConstant == true)
            {

                if (secondLine.noSlope == false)
                {

                }
                else if (secondLine.xConstant == true)
                {

                }
                else if (secondLine.yConstant == true)//Parallel
                {

                }
            }

            return commonPoint;
        }

    }
}
