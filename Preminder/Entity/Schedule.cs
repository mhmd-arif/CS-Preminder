using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preminder.Entity
{
    public class Schedule
    {
        public string _schedule { get; set; }
        public Schedule() { }
        public Schedule(string paramSch)
        {
            _schedule = paramSch;
        }
    }
}
