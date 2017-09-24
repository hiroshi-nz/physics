using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Class
{
    class Example
    {
        private Environment environment;
        private Entities entity;//replace it with entityList.
        private List<Entities> entityList;

        public int time = 0;

        public Example()
        {


            environment = new Environment(50, 50);

            InitializeEntities();


        }

        private void InitializeEntities()
        {
            entityList = new List<Entities>();

            entityList.Add(new Entities(
                1, new Class.XY(0, 0), new Class.Vector(new XY(1, 1)), new Class.Vector(new XY(0, 0)), 10));

            entityList.Add(new Entities(
                2, new Class.XY(15, 15), new Class.Vector(new XY(-1, -3)), new Class.Vector(new XY(0, 0)), 20));

            entityList.Add(new Entities(
                3, new Class.XY(10, 0), new Class.Vector(new XY(0, 0)), new Class.Vector(new XY(0, 0)), 30));

        }





        public string Tick()
        {
            string msg = "";
            
            foreach (Entities entity in entityList)
            {
                entity.UpdateTrajectory();
                entity.TryMove();
                msg += Check.CheckEntity(entity);//creating string message for parameters of the entity like velocity
            }

            //List<Entities> idMatch = entityList.Where(e => e.id == 1).ToList();
            //int x = entityList.FindIndex(e => e.id == 1);


            //collision test//
            XY commonPoint = entityList[0].trajectoryCollision(entityList[1].trajectory);
            msg += Check.CheckXY(commonPoint);
            

            environment.Refresh(entityList);
            //msg += Check.CheckVector(entity.velocity);
            msg += Check.CheckEnvironment(environment.environment);

            

            return msg;
        }

        private void OldCodeCreateEntity()//Keeping code for now
        {
            XY location = new Class.XY(0, 0);
            Vector velocity = new Class.Vector(new XY(1, 0));
            Vector acceleration = new Class.Vector(new XY(1, 0));
            double mass = 10;
            entity = new Entities(1, location, velocity, acceleration, mass);

            entity = new Entities(
                0, new Class.XY(0, 0), new Class.Vector(new XY(1, 0)), new Class.Vector(new XY(1, 0)), 10);

            entityList.Add(new Entities(1, location, velocity, acceleration, mass));
            //this will be useful for tracking object on environment map.
        }
    }
}
