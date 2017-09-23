using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Class
{
    class Check
    {
        public static string CheckEntity(Entities entity)
        {
            string msg = "";
            msg += "ID:" + entity.id;
            msg += " Location X:" + entity.location.x + " Y:" + entity.location.y;
            msg += " Velocity X:" + entity.velocity.xy.x + " Y:" + entity.velocity.xy.y;
            msg += " Acceleration X:" + entity.acceleration.xy.x + " Y:" + entity.acceleration.xy.y;
            msg += " Mass:" + entity.mass + "\r\n";
            return msg;
        }

        public static string CheckVector(Vector vector)
        {
            string msg = "";
            msg += "Vector X:" + vector.xy.x + " Y:" + vector.xy.y;
            msg += " Magnitude:" + vector.magnitude + " Angle:" + vector.angle + "\r\n";
            return msg;
        }

        public static string CheckEnvironment(int[,] environment)
        {
            string msg = "";
            int sizeX = environment.GetLength(0);
            int sizeY = environment.GetLength(1);

            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    msg += environment[i, j] + ",";
                }
                msg += "\r\n";
            }
            return msg;
        }

        public static string CheckLine(Line line)
        {
            string msg = "";
            if (line.noSlope == false)
            {
                if (line.offset > 0)
                {
                    msg += "y=" + line.slope + "x+" + line.offset + "\r\n";
                }
                else//offset is negative so I don't need + sign.
                {
                    msg += "y=" + line.slope + "x" + line.offset + "\r\n";
                }
                //msg += line.slope;
            }
            else
            {
                if(line.xConstant)
                {
                    msg += "x=" + line.x;
                }
                else if(line.yConstant)
                {
                    msg += "y=" + line.y;
                }
            }
            return msg;
        }
    }
}
