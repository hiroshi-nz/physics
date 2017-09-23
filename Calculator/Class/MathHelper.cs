using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Class
{
    class MathHelper
    {
        static public double RoundXth(double number, double xth)
        {
            number *= xth;
            number = Math.Round(number);
            number /= xth;

            return number;
        }

        static public double Distance(XY firstPoint, XY secondPoint)
        {
            double xDiff = firstPoint.x - secondPoint.x;
            double yDiff = firstPoint.y - secondPoint.y;
            double distance = Math.Sqrt (xDiff * xDiff + yDiff * yDiff);

            return distance;
        }

        static public bool CollisionCircles(XY firstCenter, double firstRadius, XY secondCenter, double secondRadius)
        {
            bool collision = false;
            double difference = Distance(firstCenter, secondCenter) - firstRadius + secondRadius;

            if(difference <= 0)
            {
                collision = true;
            }
            else
            {
                collision = false;
            }

            return collision;
        }

        static public void FindLine(XY firstPoint, XY secondPoint)
        {
            double slope = 0;

            if (firstPoint != secondPoint)//not same point
            {

                if (firstPoint.x == secondPoint.x)
                {
                    double x = firstPoint.x;//x is always this value
                }
                else if (firstPoint.y == secondPoint.y)//
                {
                    double y = firstPoint.y;//y is always this value
                }
                else
                {
                    double xDiff = firstPoint.x - secondPoint.x;
                    double yDiff = firstPoint.y - secondPoint.y;

                    slope = yDiff / xDiff;

                    double offset = slope * firstPoint.x + firstPoint.y;
                }
            }
        }
    }
}
