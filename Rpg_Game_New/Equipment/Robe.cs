using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game_New.Equipment
{
    internal class Robe : Equipments
    {
        public Robe(string type) : base(type)
        {
            Armor_class = 1.5;
            Strength = 0;
            Dexterity = 0;
            Inteligence = 3;
            Vitality = 0;
            Health = 1;
            Mana = 3;
            P_damage = 0;
            if (type == "Common")
            {
                Name = "Robe";
            }

            if (type == "Enchanted")
            {
                Name = "Enchanted Robe";
                Health += 2;
            }
            if (type == "Rare")
            {
                Name = "Rare Robe";
                Health += 3;
                Mana += 1;
            }
        }
    }
}
