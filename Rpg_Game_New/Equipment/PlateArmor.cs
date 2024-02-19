using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game_New.Equipment
{
    public class PlateArmor : Equipments
    {
        public PlateArmor(string type) : base(type)
        {
            Armor_class = 5;
            Strength = 4;
            Dexterity = -3;
            Inteligence = 0;
            Vitality = 0;
            Health = 4;
            Mana = 0;
            P_damage = 0;
            if (type == "Common")
            {
                Name = "Plate Armor";
            }

            if (type == "Enchanted")
            {
                Name = "Enchanted Plate Armor";
                Health += 2;
            }
            if (type == "Rare")
            {
                Name = "Rare Plate Armor";
                Armor_class += 1;
                Dexterity -= 2;
            }
        }
    }
}
