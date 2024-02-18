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
            Crt_damage = 0.1 * Dextenity;
            ShieldAvailable = true;
        }

        private int _strenght;
        private int _vitality;
        private int _inteligence;
        private int _dextenity;
        
        public override int Strenght
        {
            get { return _strenght; }
            set
            {
                _strenght = value;
                if(Weapon == null)
                {
                    Health = (double)(1.5 * _vitality + 0.5 * _strenght);
                    P_damage = (double)(0.5 * _strenght + 0.5 * _dextenity);
                }
                else
                {
                    Health = (double)(1.5 * _vitality + 0.5 * _strenght + Weapon.Health);
                    P_damage = (double)(0.5 * _strenght + 0.5 * _dextenity + Weapon.P_damage);
                }

            }
        }
        public override int Vitality
        {
            get { return _vitality; }
            set
            {
                _vitality = value;
                if (Weapon == null)
                {
                    Health = (double)(1.5 * _vitality + 0.5 * _strenght);
                }
                else
                {
                    Health = (double)(1.5 * _vitality + 0.5 * _strenght + Weapon.Health);
                }
            }
        }
        public override int Dextenity
        {
            get { return _dextenity; }
            set
            {
                _dextenity = value;
                if (Weapon == null)
                {
                    P_damage = (double)(0.5 * _strenght + 0.5 * value);
                    Armor = (double)(1.5 * _dextenity);
                    Crt_chanse = (double)(0.2 * _dextenity);
                    Crt_damage = (double)(0.1 * _dextenity);
                }
                
                else
                {
                    if(Weapon.Name == "Ward")
                    {
                        Crt_chanse = (double)(0.2 * _dextenity);
                        Crt_damage = (double)(0.1 * _dextenity);
                    }
                    else
                    {
                        
                        Crt_chanse = (double)(0.2 * _dextenity * Weapon.Crt_chanse);
                        Crt_damage = (double)(0.1 * _dextenity * Weapon.Crt_damage);
                    }
                    P_damage = (double)(0.5 * _strenght + 0.5 * value + Weapon.P_damage);
                    Armor = (double)(1.5 * _dextenity + Weapon.Armor);

                }
                
            }
        }
        public override int Inteligence
        {
            get 
            { 
                return _inteligence;
            }
            set
            {
                _inteligence = value;
                if(Weapon == null)
                {
                    Mana = (double)(1.2 * value);
                    M_damage = (double)(0.2 * _inteligence);
                    M_defense = (double)(0.5 * _inteligence);
                }
                else
                {
                    Mana = (double)(1.2 * value + Weapon.Mana);
                    M_damage = (double)(0.2 * _inteligence + Weapon.M_damage);
                    M_defense = (double)(0.5 * _inteligence + Weapon.M_defense);
                }
                
            }
        }
    }
}
