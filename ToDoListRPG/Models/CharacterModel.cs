using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace ToDoListRPG.Models
{
    public class CharacterModel
    {
        public int CharacterId { get; set; }
        public int Level { get; set; }
        public HairStyle Hairstyle { get; set; }
        public Color HairColor { get; set; }
        public ShirtStyle Shirt { get; set; }
        public Color ShirtColor { get; set; }
        public PantStyle Pants { get; set; }
        public Color PantColor { get; set; }
        public Color ShoeColor { get; set; }
        public EyeStyle Eyes { get; set; }
    }
}