using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoListRPG.Models
{
    public class ToDoItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }
    }
}