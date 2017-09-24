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
        public Line trajectory;

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

        public void CheckForCollision(List<Entities> entityList)
        {
            Line pathLine = new Line(location, velocity.xy);
        }

        public void UpdateTrajectory()
        {
            XY xyCalculationBuffer = location;
            XY nextLocation = xyCalculationBuffer.CalculateAddition(velocity.xy);
            trajectory = new Line(location, nextLocation);//location + velocity is next location
        }

        //I shouldn't use check for this, maybe use output or print for current check class?

        public XY trajectoryCollision(Line secondTrajectory)//horizontal, vertical not implemented!
        {
            XY commonPoint = trajectory.DoIntersect(secondTrajectory);
            return commonPoint;
        }













/*
 * Obsolete codes
 * 
        public List<Line> CheckCollisionLines(Entities secondEntity)//give lines of 2 entities.
        {

            XY xyCalculationBuffer = location;
            XY nextLocation = xyCalculationBuffer.CalculateAddition(velocity.xy);

            xyCalculationBuffer = secondEntity.location;
            XY secondNextLocation = xyCalculationBuffer.CalculateAddition(secondEntity.velocity.xy);

            Line pathLine = new Line(location, nextLocation);//location + velocity is next location
            Line secondPathLine = new Line(secondEntity.location, secondNextLocation);


            List<Line> lineList = new List<Line>();
            lineList.Add(pathLine);
            lineList.Add(secondPathLine);

            return lineList;
        }

        public XY CheckCollision(Entities secondEntity)//check do paths(trajectories) of two entities intersect or not.
        {

            XY xyCalculationBuffer = location;
            XY nextLocation = xyCalculationBuffer.CalculateAddition(velocity.xy);

            xyCalculationBuffer = secondEntity.location;
            XY secondNextLocation = xyCalculationBuffer.CalculateAddition(secondEntity.velocity.xy);

            Line pathLine = new Line(location, nextLocation);//location + velocity is next location
            Line secondPathLine = new Line(secondEntity.location, secondNextLocation);

            XY commonPoint = pathLine.DoIntersect(secondPathLine);

            return commonPoint;
        }


    */
    }
}
