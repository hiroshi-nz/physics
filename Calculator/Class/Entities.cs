using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Class
{
    class Entities
    {
        public int id;
        public XY location;
        public Vector velocity;
        public Vector acceleration;
        public double mass;

        public Entities(int id, XY location, Vector velocity, Vector acceleration, double mass)
        {
            this.id = id;
            this.location = location;
            this.velocity = velocity;
            this.acceleration = acceleration;
            this.mass = mass;
        }

        public void TryMove()
        {
            location.Add(velocity.xy);
            velocity.AddXY(acceleration.xy); 
        }
    }
}
