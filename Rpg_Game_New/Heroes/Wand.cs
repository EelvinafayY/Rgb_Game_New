using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game_New.Heroes
{
    public class Wand : Weapon
    {
        public Wand(string type) : base(type)
        {
            Strength = 0;
            Dexterity = 1;
            Inteligence = 3;
            Vitality = 0;
            Health = 0;
            Mana = 3;
            P_damage = 1;
            Armor = 0;
            M_damage = 0;
            M_defense = 0;
            ShieldAvailable = true;
            if(type == "Common")
            {
                Name = "Wand";
                Crt_chanse = 1;
                Crt_damage = 1;
            }
            
            if (type == "Enchanted")
            {
                Name = "Enchanted Wand";
                Crt_chanse = 1.05;
                Crt_damage = 4;
            }
            if(type == "Rare")
            {
                Name = "Rare Wand";
                Inteligence += 2;
                Mana += 2;
                P_damage += 2;
                Strength += 2;
                Crt_chanse = 1;
                Crt_damage = 1;
            }
        }
    }
}
