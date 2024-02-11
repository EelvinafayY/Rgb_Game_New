using MongoDB.Bson;
using MongoDB.Driver;
using Rpg_Game_New.Heroes;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Rpg_Game_New.Pages
{
    /// <summary>
    /// Логика взаимодействия для NamePage.xaml
    /// </summary>
    public partial class NamePage : Page
    {
        private string basename;

        public NamePage(string basename)
        {
            InitializeComponent();
            this.basename = basename;
            BaseNameTBX.Text = basename;
        }

        private void GoBT_Click(object sender, RoutedEventArgs e)
        {
            string bname = BaseNameTBX.Text.Trim();
            string name = NameTB.Text.Trim();
            if (bname == "Rogue")
            {
                var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == name);
                if (persRogue != null)
                    NavigationService.Navigate(new InfoHeroRogue(persRogue));
                else
                {
                    MongoDBConnection.CreateCharacterRogue(new Rogue(bname, name, 65, 20, 250, 30, 70, 15, 80, 20, 1, 10, 1000));
                }
            }
            if (bname == "Wizard")
            {
                var persesWizard = MongoDBConnection.Get<Wizard>("Rgb_Game", "CharacterCollection");
                var persWizard = persesWizard.FirstOrDefault(x => x.Name == name);
                if (persWizard != null) { }
                    //NavigationService.Navigate(new InfoWizard(persWizard));
                else
                {
                    MongoDBConnection.CreateCharacterWizard(new Wizard(bname, name, 45, 15, 80, 20, 250, 35, 70, 15, 1, 10, 1000));
                }
            }
            if (bname == "Warrior")
            {
                var persesWarroir = MongoDBConnection.Get<Warrior>("Rgb_Game", "CharacterCollection");
                var persWarrior = persesWarroir.FirstOrDefault(x => x.Name == name);
                if (persWarrior != null) { }
                    //NavigationService.Navigate(new InfoWarrior(persWarrior));
                else
                {
                    MongoDBConnection.CreateCharacterWarrior(new Warrior(bname, name, 250, 30, 80, 15, 50, 10, 100, 25, 1, 10, 1000));
                }
            }
        }
    }
}
