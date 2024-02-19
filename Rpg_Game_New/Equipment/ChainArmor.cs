using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game_New.Equipment
{
    public class ChainArmor : Equipments
    {
        public ChainArmor(string type) : base(type)
        {
            Armor_class = 4;
            Strength = 2;
            Dexterity = -1;
            Inteligence = 0;
            Vitality = 0;
            Health = 2;
            Mana = 0;
            P_damage = 0;
            if (type == "Common")
            {
                Name = "Chain Armor";
            }

            if (type == "Enchanted")
            {
                Name = "Enchanted Chain Armor";
                Health += 2;
            }
            if (type == "Rare")
            {
                Name = "Rare Chain Armor";
                Health += 3;
                Strength += 3;
            }
        }
    }
}
