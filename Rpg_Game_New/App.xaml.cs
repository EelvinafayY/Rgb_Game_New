using Rpg_Game_New.Heroes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Rpg_Game_New
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Character SelectedCharacter { get; set; }
        public static Character character; //типо выбранный перс
    }
}
