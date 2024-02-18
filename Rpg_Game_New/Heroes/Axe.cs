using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game_New.Heroes
{
    public class Axe : Weapon
    {
        public Axe(string type) : base(type)
        {
            Strength = 5;
            Dexterity = 0;
            Inteligence = 0;
            Vitality = 0;
            Health = 0;
            Mana = 0;
            P_damage = 5;
            Armor = 0;
            M_damage = 0;
            M_defense = 0;
            ShieldAvailable = true;
            if (type == "Common")
            {
                Name = "Axe";
                Crt_chanse = 1.2;
                Crt_damage = 2.7;
            }

            if (type == "Enchanted")
            {
                Name = "Enchanted Axe";
                Crt_chanse = 1.4;
                Crt_damage = 3;
            }
            if (type == "Rare")
            {
                Name = "Rare Axe";
                P_damage += 4;
                Strength += 4;
                Crt_chanse = 1.5;
                Crt_damage = 3.2;
            }
        }
    }
}
