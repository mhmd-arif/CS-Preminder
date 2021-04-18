using Preminder.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preminder.Repository
{
    public interface IScheduleRepository
    {
        Schedule[] GetAll();
        void Add(Schedule schedule);
        bool Remove(int no);
    }

    public class ScheduleRepository : IScheduleRepository
    {
        public void Add(Schedule schedule)
        {
            throw new NotImplementedException();
        }

        public Schedule[] GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Remove(int no)
        {
            throw new NotImplementedException();
        }
    }
}
