using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game_New.Equipment
{
    public class Equipments 
    {
        public double Armor_class { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Inteligence { get; set; }
        public int Vitality { get; set; }
        public double Health { get; set; }
        public double Mana { get; set; }
        public double P_damage { get; set; }

        public Equipments(string type)
        {
            Type = type;
        }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
