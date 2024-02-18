using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game_New.Heroes
{
    public class Hammer : Weapon
    {
        public Hammer(string type) : base(type)
        {
            Strength = 3;
            Dexterity = 0;
            Inteligence = 0;
            Vitality = 0;
            Health = 4;
            Mana = 0;
            P_damage = 5;
            Armor = 0;
            M_damage = 0;
            M_defense = 0;
            ShieldAvailable = true;
            if (type == "Common")
            {
                Name = "Axe";
                Crt_chanse = 1.1;
                Crt_damage = 2.5;
            }

            if (type == "Enchanted")
            {
                Name = "Enchanted Axe";
                Crt_chanse = 1.4;
                Crt_damage = 2.5;
                Dexterity += 2;
            }
            if (type == "Rare")
            {
                Name = "Rare Axe";
                P_damage += 3;
                Strength += 4;
                Crt_chanse = 1.4;
                Crt_damage = 3.2;
                Dexterity += 5;
            }
        }
    }
}
