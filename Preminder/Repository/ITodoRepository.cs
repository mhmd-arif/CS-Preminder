using Preminder.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preminder.Repository
{
    public interface ITodoRepository
    {
        ToDoList[] GetAll();
        void Add(ToDoList toDoList);
        bool Remove(int no);
    }
    public class TodoRepository : ITodoRepository
    {
        public void Add(ToDoList toDoList)
        {
            throw new NotImplementedException();
        }

        public ToDoList[] GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Remove(int no)
        {
            throw new NotImplementedException();
        }
    }
}
