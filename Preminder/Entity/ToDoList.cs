using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preminder.Entity
{
    public class ToDoList
    {
        public string todo { get; set; }
        public ToDoList() { }
        public ToDoList(string paramToDo)
        {
            todo = paramToDo;
        }
    }
}
