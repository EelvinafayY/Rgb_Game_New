using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game_New.Equipment
{
    public class LeatherArmor : Equipments
    {
        public LeatherArmor(string type) : base(type)
        {
            Armor_class = 2.5;
            Strength = 1;
            Dexterity = 3;
            Inteligence = 0;
            Vitality = 0;
            Health = 2;
            Mana = 0;
            P_damage = 0;
            if (type == "Common")
            {
                Name = "Leather Armor";
                
            }

            if (type == "Enchanted")
            {
                Name = "Enchanted Leather Armor";
                Health += 2;
            }
            if (type == "Rare")
            {
                Name = "Rare Leather Armor";
                Health += 3;
                Mana += 1;
            }
        }
    }
}
