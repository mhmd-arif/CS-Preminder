﻿using Preminder.Entity;
using System;

namespace Preminder.Repository
{
    public interface IActivityRepository
    {
        Activity[] GetAll();
        void Add(Activity activity);
        bool Remove(int no);
    }

    public class ActivityRepository : IActivityRepository
    {
        public void Add(Activity activity)
        {
            throw new NotImplementedException();
        }

        public Activity[] GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Remove(int no)
        {
            throw new NotImplementedException();
        }
    }

}
