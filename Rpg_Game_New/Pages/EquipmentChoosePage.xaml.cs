using Rpg_Game_New.Heroes;
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
    /// Логика взаимодействия для EquipmentChoosePage.xaml
    /// </summary>
    public partial class EquipmentChoosePage : Page
    {
        Character contextpers { get; set; }
        public EquipmentChoosePage(Character character)
        {
            InitializeComponent();
        }

        private void RobeBT_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LeatherArmorBT_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ChainArmorBT_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PlateArmorBT_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
