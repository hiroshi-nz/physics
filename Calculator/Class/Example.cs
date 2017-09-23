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
        private int id = 1;

        public Example()
        {


            environment = new Environment(50, 50);

            InitializeEntities();


        }

        private void InitializeEntities()
        {
            entityList = new List<Entities>();

            entityList.Add(new Entities(
                1, new Class.XY(0, 0), new Class.Vector(new XY(1, 0)), new Class.Vector(new XY(1, 0)), 10));

            entityList.Add(new Entities(
                2, new Class.XY(5, 0), new Class.Vector(new XY(0, 0)), new Class.Vector(new XY(0, 0)), 20));

            entityList.Add(new Entities(
                3, new Class.XY(10, 0), new Class.Vector(new XY(0, 0)), new Class.Vector(new XY(0, 0)), 30));

        }





        public string Tick()
        {
            string msg = "";
            
            foreach (Entities entity in entityList)
            {
                entity.TryMove();
                msg += Check.CheckEntity(entity);//creating string message for parameters of the entity like velocity
            }

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
            entity = new Entities(id, location, velocity, acceleration, mass);

            entity = new Entities(
                0, new Class.XY(0, 0), new Class.Vector(new XY(1, 0)), new Class.Vector(new XY(1, 0)), 10);

            entityList.Add(new Entities(id, location, velocity, acceleration, mass));
            //this will be useful for tracking object on environment map.
        }
    }
}
