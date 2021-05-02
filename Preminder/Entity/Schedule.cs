using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preminder.Entity
{
    public class Schedule
    {
        //  properties
        public int Id { get; set; }
        public string Course { get; set; }
        public string Hour { get; set; }
        public string Day { get; set; }

        //  constructor
        public Schedule() { }
        public Schedule(string paramCS)
        {
            Course = paramCS;
        }
    }
}
