using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {

        private IToDoList todolist = new ToDoList.Models.ToDoList();

        // Display ToDo List
        public ActionResult Index()
        {
            ViewBag.Title ="To Do List";
            return View("Index", todolist.GetList());
        }

        // Add task to list
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FormCollection val)
        {
            todolist.Add(val["taskinfo"]);
            return RedirectToAction("Index");
        }

        // complete a task
        public ActionResult Complete(int id)
        {
            todolist.Complete(id);
            return RedirectToAction("Index");
        }

        // remove a task
        public ActionResult Remove(int id)
        {
            todolist.Remove(id);
            return RedirectToAction("Index");
        }
    }
}