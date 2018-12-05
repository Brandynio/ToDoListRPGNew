using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoListRPG.Models
{
    public class ListModel
    {
        public List<ToDoItem> ToDoList { get; set; }
        public ListType Type { get; set; }
    }
}