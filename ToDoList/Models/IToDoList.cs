using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public interface IToDoList
    {
        IEnumerable<Task> GetList();
        void Add(String taskinfo);
        void Remove(int id);
        void Complete(int id);
    }
}
