using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game_New.Heroes
{
    public class Character
    {
        public Weapon Weapon {  get; set; }
        public ObjectId _id { get; set; }
        public string BaseName { get; set; }
        public string Name { get; set; }


        //настраиваемые характеристики
        public int Strenght { get; set; }
        public int Max_Strenght { get; set; }
        public int Dextenity { get; set; }
        public int Max_Dextenity { get; set; }
        public int Inteligence { get; set; }
        public int Max_Inteligence { get; set; }
        public int Vitality { get; set; }
        public int Max_Vitality { get; set; }
        //конструктор
        public Character(string basename, string name, int max_Strenght, int strenght, int max_Dextenity,
            int dextenity, int max_Inteligence, int inteligence,
            int max_Vitality, int vitality, int level, int points, int levelpoints)
        {
            BaseName = basename;
            Name = name;
            Max_Strenght = max_Strenght;
            Strenght = strenght;
            Max_Dextenity = max_Dextenity;
            Dextenity = dextenity;
            Max_Inteligence = max_Inteligence;
            Inteligence = inteligence;
            Max_Vitality = max_Vitality;
            Vitality = vitality;
            Level = level;
            Points = points;
            Levelpoints = levelpoints;
        }
        //расчетные характеристики
        public double Health { get; set; }
        public double Mana { get; set; }
        public double P_damage { get; set; }
        public double Armor { get; set; }
        public double M_damage { get; set; }
        public double M_defense { get; set; }
        public double Crt_chanse { get; set; }
        public double Crt_damage { get; set; }

        //Уровни
        public int Level { get; set; }
        public int Points { get; set; }
        public int Levelpoints { get; set; }
    }
}
