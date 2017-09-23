using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Class
{

    //This class might be unnecessery.
    class ObjectTracker
    {

        public List<TrackerEntry> objectTracker;


        public ObjectTracker()
        {
            objectTracker = new List<TrackerEntry>();
        }

        public void Add(int ID, string Name)
        {
            objectTracker.Add(new TrackerEntry(10, "aa"));
        }

    }
}
