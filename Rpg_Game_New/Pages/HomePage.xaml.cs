using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private void WarriorCharacterBT_Click(object sender, RoutedEventArgs e)
        {
            string basename = WarriorTB.Text;
            NavigationService.Navigate(new Pages.NamePage(basename));
        }

        private void RogueCharacterBT_Click(object sender, RoutedEventArgs e)
        {
            string basename = RogueTB.Text;
            NavigationService.Navigate(new Pages.NamePage(basename));
        }

        private void WizardCharacterBT_Click(object sender, RoutedEventArgs e)
        {
            string basename = WizardTB.Text;
            NavigationService.Navigate(new Pages.NamePage(basename));
        }
    }
}
