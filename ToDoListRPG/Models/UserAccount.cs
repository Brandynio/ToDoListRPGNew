using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoListRPG.Models
{
    public class UserAccount
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public CharacterModel Character { get; set; }
        public List<ListModel> Lists { get; set; }
        public bool IsAdmin { get; set; }
    }
}