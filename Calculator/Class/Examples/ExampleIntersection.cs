using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Class.Examples
{
    class ExampleIntersection
    {
        private Environment environment;
        private List<Entities> entityList;
        public int time = 0;

        public ExampleIntersection()
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
                2, new Class.XY(5, 0), new Class.Vector(new XY(0, 1)), new Class.Vector(new XY(0, 0)), 20));
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
    }
}

