using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game_New.Heroes
{
    public partial class Rogue : Character
    {

        public Rogue(string basename, string name, int max_Strenght, int strenght, int max_Dextenity, int dextenity, int max_Inteligence, int inteligence, int max_Vitality, int vitality, int level,
            int points, int levelpoints) 
            : base(basename, name, max_Strenght, strenght, max_Dextenity, dextenity, max_Inteligence, inteligence, max_Vitality, vitality, level, points, levelpoints)
        {
            Health = 1.5 * Vitality + 0.5 * Strenght;
            Mana = 1.2 * Inteligence;
            P_damage = 0.5 * Strenght + 0.5 * Dextenity;
            Armor = 1.5 * Dextenity;
            M_damage = 0.2 * Inteligence;
            M_defense = 0.5 * Inteligence;
            Crt_chanse = 0.2 * Dextenity;
            Crt_damage = Dextenity;
        }
        
    }
}
