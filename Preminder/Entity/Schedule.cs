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
        public Schedule(int _id, string _course, string _hour, string _day)
        {
            Id = _id;
            Course = _course;
            Hour = _hour;
            Day = _day;
        }
    }
}
