using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game_New.Heroes
{
    public class Dagger : Weapon
    {
        public Dagger(string type) : base(type)
        {
            Strength = 0;
            Dexterity = 4;
            Inteligence = 0;
            Vitality = 0;
            Health = 0;
            Mana = 0;
            P_damage = 2;
            Armor = 0;
            M_damage = 0;
            M_defense = 0;
            ShieldAvailable = false;
            if (type == "Common")
            {
                Name = "Dagger";
                Crt_chanse = 1.6;
                Crt_damage = 1.7;
            }

            if (type == "Enchanted")
            {
                Name = "Enchanted Dagger";
                Crt_chanse = 1.7;
                Crt_damage = 1.8;
            }
            if (type == "Rare")
            {
                Name = "Rare Dagger";
                Mana += 2;
                P_damage += 2;
                Strength += 2;
                Dexterity += 4;
                
            }
        }
    }
}
