using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game_New.Heroes
{
    public class Weapon
    {
        public Weapon(string name, string type) 
        {
            Name = name;
            Type = type;
        }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
