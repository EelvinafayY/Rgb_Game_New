using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game_New.Heroes
{
    public class Staff : Weapon
    {
        public Staff(string type) : base(type)
        {
            Strength = 0;
            Dexterity = 1 * 2;
            Inteligence = 3 * 2;
            Vitality = 0;
            Health = 0;
            Mana = 3 * 1.7;
            P_damage = 1 * 1.7;
            Armor = 0;
            M_damage = 0;
            M_defense = 0;
            ShieldAvailable = false;
            if (type == "Common")
            {
                Name = "Wand";
                Crt_chanse = 1.7;
                Crt_damage = 1.7;
            }

            if (type == "Enchanted")
            {
                Name = "Enchanted Wand";
                Crt_chanse = 2;
                Crt_damage = 2;
            }
            if (type == "Rare")
            {
                Name = "Rare Wand";
                Inteligence += 4;
                Mana += 4;
                P_damage += 4;
                Strength += 4;
                Crt_chanse = 2;
                Crt_damage = 2;
            }
        }
    }
}
