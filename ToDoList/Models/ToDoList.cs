using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class ToDoList : IToDoList
    {

        private static IList<Task> todolist = new List<Task>()
        {
            new Task()
            {
                Id = 1,
                TaskInfo = "Book dentist appointment",
                Complete = false
            },
            new Task()
            {
                Id = 2,
                TaskInfo = "Visit Grandma",
                Complete = false
            },
            new Task()
            {
                Id = 3,
                TaskInfo = "Pay car insurance",
                Complete = true
            }
        };

        public void Add(String taskinfo)
        {
            Task task = new Task()
            {
                Id = (todolist.Count > 0)?(todolist.OrderByDescending(item => item.Id).FirstOrDefault().Id) + 1:1,
                TaskInfo = taskinfo,
                Complete = false
            };

            todolist.Add(task);
        }

        public void Complete(int id)
        {
            todolist.First(q => q.Id == id).Complete = !todolist.First(q => q.Id == id).Complete;
        }

        public void Remove(int id)
        {
            todolist.Remove(todolist.First(q => q.Id == id));
        }

        public IEnumerable<Task> GetList()
        {
            return todolist.OrderByDescending(item => item.Id);
        }
    }
}