using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Class
{
    class TrackerEntry
    {
        public int id { get; set; }
        public string name { get; set; }

        public TrackerEntry(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
