﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preminder.Entity
{
    public class Activity
    {
        public string _activity { get; set; }
        public Activity() { }
        public Activity(string paramAct)
        {
            _activity = paramAct;
        }
    }
}
