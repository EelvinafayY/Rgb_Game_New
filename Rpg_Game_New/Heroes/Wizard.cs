using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game_New.Heroes
{
    public partial class Wizard : Character
    {
        public Wizard(string basename, string name, int max_Strenght, int strenght, int max_Dextenity, int dextenity, int max_Inteligence, int inteligence, int max_Vitality, int vitality, int level,
            int points, int levelpoints)
            : base(basename, name, max_Strenght, strenght, max_Dextenity, dextenity, max_Inteligence, inteligence, max_Vitality, vitality, level, points, levelpoints)
        {
            Health = 1.4 * Vitality + 0.2 * Strenght;
            Mana = 1.5 * Inteligence;
            P_damage = 0.5 * Strenght;
            Armor = Dextenity;
            M_damage = Inteligence;
            M_defense = Inteligence;
            Crt_chanse = 0.2 * Dextenity;
            Crt_damage = Dextenity;
        }
    }
}
