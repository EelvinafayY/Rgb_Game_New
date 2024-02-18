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
    /// Логика взаимодействия для InfoWarriorPage.xaml
    /// </summary>
    public partial class InfoWarriorPage : Page
    {
        Warrior contextpers { get; set; }
        string selectedWarrior;
        public InfoWarriorPage(Warrior persWarrior)
        {
            InitializeComponent();
            contextpers = persWarrior;
            contextpers.Inteligence += 1;
            contextpers.Dextenity += 1;
            contextpers.Strenght += 1;
            contextpers.Vitality += 1;
            MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
            contextpers = persWarrior;
            contextpers.Inteligence -= 1;
            contextpers.Dextenity -= 1;
            contextpers.Strenght -= 1;
            contextpers.Vitality -= 1;
            MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
            this.DataContext = contextpers;
        }

        private void PlusStrBT_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(CountStrenghtTBX.Text) + 1;
            int point = int.Parse(PointsInfoTB.Text) - 1;
            if (int.Parse(CountStrenghtTBX.Text) > contextpers.Max_Strenght)
            {
                CountStrenghtTBX.Text = contextpers.Max_Strenght.ToString();
            }
            else
            {
                if (point >= 0)
                {
                    CountStrenghtTBX.Text = a.ToString();
                    PointsInfoTB.Text = point.ToString();
                    contextpers.Strenght = a;
                    contextpers.Points = point;
                }
                else
                {
                    MessageBox.Show("Недостаточно очков для изменения характеристики");
                }
            }
            MongoDBConnection.UpdateWarrior(contextpers as Warrior);
            DataContext = contextpers;
            var persesWarrior = MongoDBConnection.Get<Warrior>("Rgb_Game", "CharacterCollection");
            var persWarrior = persesWarrior.FirstOrDefault(x => x.Name == NameTB.Text);
            NavigationService.Navigate(new InfoWarriorPage(persWarrior));

        }

        private void MinusStrBT_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(CountStrenghtTBX.Text) - 1;
            int point = int.Parse(PointsInfoTB.Text) + 1;
            if (int.Parse(CountStrenghtTBX.Text) > contextpers.Max_Strenght)
            {
                CountStrenghtTBX.Text = contextpers.Max_Strenght.ToString();
            }
            if (int.Parse(CountStrenghtTBX.Text) <= 20)
            {
                CountStrenghtTBX.Text = 20.ToString();
                contextpers.Strenght = 20;
            }
            if (int.Parse(CountStrenghtTBX.Text) > 20)
            {
                CountStrenghtTBX.Text = a.ToString();
                PointsInfoTB.Text = point.ToString();
                contextpers.Strenght = a;
                contextpers.Points = point;
            }
            if (int.Parse(CountDextenityTBX.Text) > 30)
            {
                CountDextenityTBX.Text = a.ToString();
                PointsInfoTB.Text = point.ToString();
                contextpers.Dextenity = a;
                contextpers.Points = point;
            }
            MongoDBConnection.UpdateWarrior(contextpers as Warrior);
            DataContext = contextpers;
            var persesWarrior = MongoDBConnection.Get<Warrior>("Rgb_Game", "CharacterCollection");
            var persWarrior = persesWarrior.FirstOrDefault(x => x.Name == NameTB.Text);
            NavigationService.Navigate(new InfoWarriorPage(persWarrior));
        }

        private void PlusDexBT_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(CountDextenityTBX.Text) + 1;
            int point = int.Parse(PointsInfoTB.Text) - 1;
            if (int.Parse(CountDextenityTBX.Text) > contextpers.Max_Dextenity)
            {
                CountDextenityTBX.Text = contextpers.Max_Dextenity.ToString();
            }
            else
            {
                if (point >= 0)
                {
                    CountDextenityTBX.Text = a.ToString();
                    PointsInfoTB.Text = point.ToString();
                    contextpers.Points = point;
                    contextpers.Dextenity = a;
                }
                else
                {
                    MessageBox.Show("Недостаточно очков для изменения характеристики");
                }

            }

            MongoDBConnection.UpdateWarrior(contextpers as Warrior);
            DataContext = contextpers;
            var persesWarrior = MongoDBConnection.Get<Warrior>("Rgb_Game", "CharacterCollection");
            var persWarrior = persesWarrior.FirstOrDefault(x => x.Name == NameTB.Text);
            NavigationService.Navigate(new InfoWarriorPage(persWarrior));
        }

        private void MinusDexBT_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(CountDextenityTBX.Text) - 1;
            int point = int.Parse(PointsInfoTB.Text) + 1;
            if (int.Parse(CountDextenityTBX.Text) > contextpers.Max_Dextenity)
            {
                CountDextenityTBX.Text = contextpers.Max_Dextenity.ToString();
            }
            if (int.Parse(CountDextenityTBX.Text) > 30)
            {
                CountDextenityTBX.Text = a.ToString();
                PointsInfoTB.Text = point.ToString();
                contextpers.Dextenity = a;
                contextpers.Points = point;
            }
            if (int.Parse(CountDextenityTBX.Text) <= 30)
            {
                CountDextenityTBX.Text = 30.ToString();
                contextpers.Dextenity = 30;
            }
            MongoDBConnection.UpdateWarrior(contextpers as Warrior);
            DataContext = contextpers;
            var persesWarrior = MongoDBConnection.Get<Warrior>("Rgb_Game", "CharacterCollection");
            var persWarrior = persesWarrior.FirstOrDefault(x => x.Name == NameTB.Text);
            NavigationService.Navigate(new InfoWarriorPage(persWarrior));
        }

        private void PlusIntBT_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(CountInteligenceTBX.Text) + 1;
            int point = int.Parse(PointsInfoTB.Text) - 1;
            if (int.Parse(CountInteligenceTBX.Text) > contextpers.Max_Inteligence)
            {
                CountInteligenceTBX.Text = contextpers.Max_Inteligence.ToString();
            }
            else
            {
                if (point >= 0)
                {
                    CountInteligenceTBX.Text = a.ToString();
                    PointsInfoTB.Text = point.ToString();
                    contextpers.Points = point;
                    contextpers.Inteligence = a;
                }
                else
                {
                    MessageBox.Show("Недостаточно очков для изменения характеристики");
                }
            }
            MongoDBConnection.UpdateWarrior(contextpers as Warrior);
            DataContext = contextpers;
            var persesWarrior = MongoDBConnection.Get<Warrior>("Rgb_Game", "CharacterCollection");
            var persWarrior = persesWarrior.FirstOrDefault(x => x.Name == NameTB.Text);
            NavigationService.Navigate(new InfoWarriorPage(persWarrior));

        }

        private void MinusIntBT_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(CountInteligenceTBX.Text) - 1;
            int point = int.Parse(PointsInfoTB.Text) + 1;
            if (int.Parse(CountInteligenceTBX.Text) > contextpers.Max_Inteligence)
            {
                CountInteligenceTBX.Text = contextpers.Max_Inteligence.ToString();
            }
            if (a < 0)
            {
                CountInteligenceTBX.Text = 0.ToString();
            }
            if (int.Parse(CountInteligenceTBX.Text) < 15)
            {
                CountInteligenceTBX.Text = 15.ToString();
                contextpers.Inteligence = 15;
            }
            if (int.Parse(CountInteligenceTBX.Text) > 15)
            {
                CountInteligenceTBX.Text = a.ToString();
                PointsInfoTB.Text = point.ToString();
                contextpers.Inteligence = a;
                contextpers.Points = point;
            }
            MongoDBConnection.UpdateWarrior(contextpers as Warrior);
            DataContext = contextpers;
            var persesWarrior = MongoDBConnection.Get<Warrior>("Rgb_Game", "CharacterCollection");
            var persWarrior = persesWarrior.FirstOrDefault(x => x.Name == NameTB.Text);
            NavigationService.Navigate(new InfoWarriorPage(persWarrior));
        }

        private void PlusVitBT_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(CountVitalityTBX.Text) + 1;
            int point = int.Parse(PointsInfoTB.Text) - 1;
            if (int.Parse(CountVitalityTBX.Text) > contextpers.Max_Vitality)
            {
                CountVitalityTBX.Text = contextpers.Max_Vitality.ToString();
            }
            else
            {
                if (point >= 0)
                {
                    CountVitalityTBX.Text = a.ToString();
                    PointsInfoTB.Text = point.ToString();
                    contextpers.Points = point;
                    contextpers.Vitality = a;
                }
                else
                {
                    MessageBox.Show("Not enough points!");
                }

            }
            MongoDBConnection.UpdateWarrior(contextpers as Warrior);
            DataContext = contextpers;
            var persesWarrior = MongoDBConnection.Get<Warrior>("Rgb_Game", "CharacterCollection");
            var persWarrior = persesWarrior.FirstOrDefault(x => x.Name == NameTB.Text);
            NavigationService.Navigate(new InfoWarriorPage(persWarrior));

        }

        private void MinusVitBT_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(CountVitalityTBX.Text) - 1;
            int point = int.Parse(PointsInfoTB.Text) + 1;
            if (int.Parse(CountVitalityTBX.Text) > contextpers.Max_Vitality)
            {
                CountVitalityTBX.Text = contextpers.Max_Vitality.ToString();
            }
            if (int.Parse(CountVitalityTBX.Text) <= 20)
            {
                CountVitalityTBX.Text = 20.ToString();
                contextpers.Vitality = 20;
            }
            if (int.Parse(CountVitalityTBX.Text) > 20)
            {
                CountVitalityTBX.Text = a.ToString();
                PointsInfoTB.Text = point.ToString();
                contextpers.Vitality = a;
                contextpers.Points = point;
            }
            MongoDBConnection.UpdateWarrior(contextpers as Warrior);
            DataContext = contextpers;
            var persesWarrior = MongoDBConnection.Get<Warrior>("Rgb_Game", "CharacterCollection");
            var persWarrior = persesWarrior.FirstOrDefault(x => x.Name == NameTB.Text);
            NavigationService.Navigate(new InfoWarriorPage(persWarrior));
        }

        private void UpLevelBT_Click(object sender, RoutedEventArgs e)
        {
            int levelpoints = Convert.ToInt32(contextpers.Levelpoints);
            int level = Convert.ToInt32(contextpers.Level);
            int point = Convert.ToInt32(contextpers.Points);

            if (levelpoints - level * 1000 >= 0)
            {
                if (level < 10)
                {
                    levelpoints = levelpoints + 1000 * (level + 1);
                    level++;
                    point += 10;

                    LevelInfoTB.Text = level.ToString();
                    PointsInfoTB.Text = point.ToString();
                    CountLevelPointTBX.Text = levelpoints.ToString();
                    MessageBox.Show("Level increased!");
                }
            }
            contextpers.Level = int.Parse(LevelInfoTB.Text);
            contextpers.Points = int.Parse(PointsInfoTB.Text);
            contextpers.Levelpoints = int.Parse(CountLevelPointTBX.Text);
            MongoDBConnection.UpdateWarrior(contextpers as Warrior);
            DataContext = contextpers;
            var persesWarrior = MongoDBConnection.Get<Warrior>("Rgb_Game", "CharacterCollection");
            var persWarrior = persesWarrior.FirstOrDefault(x => x.Name == NameTB.Text);
            NavigationService.Navigate(new InfoWarriorPage(persWarrior));
        }
        private void NameTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            contextpers.Name = NameTB.Text;
            MongoDBConnection.UpdateWarrior(contextpers as Warrior);
            DataContext = contextpers;

        }

        private void ChooseWeaponBT_Click(object sender, RoutedEventArgs e)
        {
            var persesWarrior = MongoDBConnection.Get<Character>("Rgb_Game", "CharacterCollection");
            var persWarrior = persesWarrior.FirstOrDefault(x => x.Name == NameTB.Text);
            NavigationService.Navigate(new WeaponChoosePage(persWarrior));
        }
    }
}
