using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Class
{
    class Vector
    {

        public double magnitude { get; private set; }//readonly from the outside class, but can be modified from the inside.
        public double angle { get; private set; }
        public XY xy { get; private set; }

        public Vector(double magnitude, double angle)
        {
            this.magnitude = magnitude;
            this.angle = angle;
            MagAngToXY(magnitude, angle);
        }

        public Vector(XY xy)
        {
            this.xy = xy;
            XYtoMagAng(xy);
        }

        public void UpdateMagAng(double magnitude, double angle)
        {
            this.magnitude = magnitude;
            this.angle = angle;
            MagAngToXY(magnitude, angle);
        }


        public void UpdateXY(XY xy)

        {
            this.xy = xy;
            XYtoMagAng(xy);
        }

        public void AddXY(XY xy)
        {
            this.xy.Add(xy);
            XYtoMagAng(this.xy);           
        }

        private void XYtoMagAng(XY xy)
        {        
            this.magnitude = Math.Sqrt(xy.x * xy.x + xy.y * xy.y);
            this.angle = RadianToAngle(Math.Atan(xy.y / xy.x));
        }

        private void MagAngToXY(double magnitude, double angle)
        {
            xy = new XY(magnitude * Math.Cos(AngleToRadian(angle)), magnitude * Math.Sin(AngleToRadian(angle)));
        }


        private double AngleToRadian(double angle)
        {
            return (Math.PI / 180) * angle;
        }

        private double RadianToAngle(double radian)
        {
            return 180 * radian / Math.PI;
        }

        private double SinAngle(double angle)
        {
            return Math.Sin((Math.PI / 180) * angle);
        }
        private double CosAngle(double angle)
        {
            return Math.Cos((Math.PI / 180) * angle);
        }
    }
}

