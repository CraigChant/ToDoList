﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string TaskInfo { get; set; }
        public Boolean Complete { get; set; }
    }
}