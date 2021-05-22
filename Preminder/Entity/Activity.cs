using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preminder.Entity
{
    public class Activity
    {
        // properties
        public string activity { get; set; }

        // constructor
        public Activity() { }
        public Activity(string paramAct)
        {
            activity = paramAct;
        }
    }
}
