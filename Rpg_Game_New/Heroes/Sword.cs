using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game_New.Heroes
{
    public class Sword : Weapon
    {
        public Sword(string type) : base(type)
        {
            Strength = 2;
            Dexterity = 1;
            Inteligence = 0;
            Vitality = 0;
            Health = 0;
            Mana = 0;
            P_damage = 4;
            Armor = 0;
            M_damage = 0;
            M_defense = 0;
            ShieldAvailable = true;
            if (type == "Common")
            {
                Name = "Sword";
                Crt_chanse = 1.35;
                Crt_damage = 2.5;
            }

            if (type == "Enchanted")
            {
                Name = "Enchanted Sword";
                Crt_chanse = 1.5;
                Crt_damage = 2.5;
                Strength += 1;
            }
            if (type == "Rare")
            {
                Name = "Rare Sword";
                Mana += 3;
                P_damage += 3;
                Strength += 2;
                Dexterity += 4;

            }
        }
    }
}
