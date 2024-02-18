using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game_New.Heroes
{
    public class Weapon
    {
        public Weapon(string type) 
        {
            Type = type;
        }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Inteligence { get; set; }
        public int Vitality { get; set; }
        public double Health { get; set; }
        public double Mana { get; set; }
        public double P_damage { get; set; }
        public double Armor { get; set; }
        public double M_damage { get; set; }
        public double M_defense { get; set; }
        public double Crt_chanse { get; set; }
        public double Crt_damage { get; set; }
        public bool ShieldAvailable { get; set; }

    }
}
