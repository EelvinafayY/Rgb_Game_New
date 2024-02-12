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
using System.Text.RegularExpressions;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;
using System.Xml.Linq;
using System.Data.Common;
using System.Security.RightsManagement;
using static System.Net.Mime.MediaTypeNames;

namespace Rpg_Game_New.Pages
{
    /// <summary>
    /// Логика взаимодействия для InfoHeroRogue.xaml
    /// </summary>
    public partial class InfoHeroRogue : Page
    {
        Rogue contextpers {  get; set; }
        string selectedRogue;
        public InfoHeroRogue(Rogue persRogue)
        {
            InitializeComponent();
            contextpers = persRogue;
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
                    PointsInfoTB.Text = point.ToString(); ;
                }
                else
                {
                    MessageBox.Show("Недостаточно очков для изменения характеристики");
                }
            }

            contextpers.Strenght = a;
            contextpers.Health = ((double.Parse(CountVitalityTBX.Text) * 1.5) + (double.Parse(CountStrenghtTBX.Text) * 0.5));
            contextpers.P_damage = double.Parse(CountStrenghtTBX.Text) * 0.5 + double.Parse(CountDextenityTBX.Text) * 0.5;
            MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
            DataContext = contextpers;
            var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
            var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
            NavigationService.Navigate(new InfoHeroRogue(persRogue));

        }

        private void MinusStrBT_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(CountStrenghtTBX.Text) - 1;
            int point = int.Parse(PointsInfoTB.Text) + 1;
            if (int.Parse(CountStrenghtTBX.Text) > contextpers.Max_Strenght)
            {
                CountStrenghtTBX.Text = contextpers.Max_Strenght.ToString();
            }
            if (a < 0)
            {
                CountStrenghtTBX.Text = 0.ToString();
            }
            if (a >= 1)
            {
                CountStrenghtTBX.Text = a.ToString();
                PointsInfoTB.Text = point.ToString();
            }
            if (a == 0)
            {
                CountStrenghtTBX.Text = a.ToString();
                PointsInfoTB.Text = point.ToString();
            }
            contextpers.Points = point;
            contextpers.Strenght = a;
            contextpers.Health = ((double.Parse(CountVitalityTBX.Text) * 1.5) + (double.Parse(CountStrenghtTBX.Text) * 0.5));
            contextpers.P_damage = double.Parse(CountStrenghtTBX.Text) * 0.5 + double.Parse(CountDextenityTBX.Text) * 0.5;
            MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
            DataContext = contextpers;
            var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
            var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
            NavigationService.Navigate(new InfoHeroRogue(persRogue));
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
                    PointsInfoTB.Text = point.ToString(); ;
                }
                else
                {
                    MessageBox.Show("Недостаточно очков для изменения характеристики");
                }

            }
            contextpers.Points = point;
            contextpers.Dextenity = a;
            contextpers.P_damage = double.Parse(CountStrenghtTBX.Text) * 0.5 + double.Parse(CountDextenityTBX.Text) * 0.5;
            contextpers.Armor = double.Parse(CountDextenityTBX.Text) * 1.5;
            contextpers.Crt_chanse = double.Parse(CountDextenityTBX.Text) * 0.2;
            contextpers.Crt_damage = double.Parse(CountDextenityTBX.Text);
            MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
            DataContext = contextpers;
            var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
            var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
            NavigationService.Navigate(new InfoHeroRogue(persRogue));
        }

        private void MinusDexBT_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(CountDextenityTBX.Text) - 1;
            int point = int.Parse(PointsInfoTB.Text) + 1;
            if (int.Parse(CountDextenityTBX.Text) > contextpers.Max_Dextenity)
            {
                CountDextenityTBX.Text = contextpers.Max_Dextenity.ToString();
            }
            if (a < 0)
            {
                CountDextenityTBX.Text = 0.ToString();
            }
            if (a >= 1)
            {
                CountDextenityTBX.Text = a.ToString();
                PointsInfoTB.Text = point.ToString();
            }
            if (a == 0)
            {
                CountDextenityTBX.Text = a.ToString();
                PointsInfoTB.Text = point.ToString();
            }
            contextpers.Points = point;
            contextpers.Dextenity = a;
            contextpers.P_damage = double.Parse(CountStrenghtTBX.Text) * 0.5 + double.Parse(CountDextenityTBX.Text) * 0.5;
            contextpers.Armor = double.Parse(CountDextenityTBX.Text) * 1.5;
            contextpers.Crt_chanse = double.Parse(CountDextenityTBX.Text) * 0.2;
            contextpers.Crt_damage = double.Parse(CountDextenityTBX.Text);
            MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
            DataContext = contextpers;
            var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
            var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
            NavigationService.Navigate(new InfoHeroRogue(persRogue));
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
                    PointsInfoTB.Text = point.ToString(); ;
                }
                else
                {
                    MessageBox.Show("Недостаточно очков для изменения характеристики");
                }
            }
            contextpers.Points = point;
            contextpers.Inteligence = a;
            contextpers.Mana = double.Parse(CountInteligenceTBX.Text) * 1.2;
            contextpers.M_defense = double.Parse(CountInteligenceTBX.Text) * 0.5;
            contextpers.M_damage = double.Parse(CountInteligenceTBX.Text) * 0.2;
            MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
            DataContext = contextpers;
            var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
            var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
            NavigationService.Navigate(new InfoHeroRogue(persRogue));

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
            if (a >= 1)
            {
                CountInteligenceTBX.Text = a.ToString();
                PointsInfoTB.Text = point.ToString();
            }
            if (a == 0)
            {
                CountInteligenceTBX.Text = a.ToString();
                PointsInfoTB.Text = point.ToString();
            }
            contextpers.Points = point;
            contextpers.Inteligence = a;
            contextpers.Mana = double.Parse(CountInteligenceTBX.Text) * 1.2;
            contextpers.M_defense = double.Parse(CountInteligenceTBX.Text) * 0.5;
            contextpers.M_damage = double.Parse(CountInteligenceTBX.Text) * 0.2;
            MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
            DataContext = contextpers;
            var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
            var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
            NavigationService.Navigate(new InfoHeroRogue(persRogue));
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
                    PointsInfoTB.Text = point.ToString(); ;
                }
                else
                {
                    MessageBox.Show("Not enough points!");
                }

            }
            contextpers.Points = point;
            contextpers.Vitality = a;
            contextpers.Health = ((double.Parse(CountVitalityTBX.Text) * 1.5) + (double.Parse(CountStrenghtTBX.Text) * 0.5));
            MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
            DataContext = contextpers;
            var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
            var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
            NavigationService.Navigate(new InfoHeroRogue(persRogue));

        }

        private void MinusVitBT_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(CountVitalityTBX.Text) - 1;
            int point = int.Parse(PointsInfoTB.Text) + 1;
            if (int.Parse(CountVitalityTBX.Text) > contextpers.Max_Vitality)
            {
                CountVitalityTBX.Text = contextpers.Max_Vitality.ToString();
            }
            if (a < 0)
            {
                CountVitalityTBX.Text = 0.ToString();
            }
            if (a >= 1)
            {
                CountVitalityTBX.Text = a.ToString();
                PointsInfoTB.Text = point.ToString();
            }
            if (a == 0)
            {
                CountVitalityTBX.Text = a.ToString();
                PointsInfoTB.Text = point.ToString();
            }
            contextpers.Points = point;
            contextpers.Vitality = a;
            contextpers.Health = ((double.Parse(CountVitalityTBX.Text) * 1.5) + (double.Parse(CountStrenghtTBX.Text) * 0.5));
            MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
            DataContext = contextpers;
            var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
            var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
            NavigationService.Navigate(new InfoHeroRogue(persRogue));
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
            MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
            DataContext = contextpers;
            var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
            var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
            NavigationService.Navigate(new InfoHeroRogue(persRogue));
        }

        //private void ReadyBT_Click(object sender, RoutedEventArgs e)
        //{
        //    var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
        //    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
        //    NavigationService.Navigate(new InfoHeroRogue(persRogue));
        //}

  
        string weaponcontext;
        private void WeaponCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            weaponcontext = ((TextBlock)WeaponCB.SelectedItem).Text;
            if (weaponcontext == "Wand")
            {
                Weapon weapon = new Weapon("Wand", "Common");
                contextpers.Weapon = weapon;
                contextpers.Inteligence = contextpers.Inteligence + 5;
                contextpers.P_damage = contextpers.P_damage + 2;
                contextpers.Mana = contextpers.Mana + 5;
            }
            
          
            else if (weaponcontext == "Dagger")
            {
                Weapon weapon = new Weapon("Dagger", "Common");
                contextpers.Weapon = weapon;
                contextpers.Dextenity = contextpers.Dextenity + 4;
                contextpers.P_damage = contextpers.P_damage + 3;
                contextpers.Crt_chanse = contextpers.Crt_chanse + (contextpers.Crt_chanse / 100 * 60);
                contextpers.Crt_damage = contextpers.Crt_damage + (contextpers.Crt_damage / 100 * 70);

            }
            else if (weaponcontext == "Axe")
            {
                Weapon weapon = new Weapon("Axe", "Common");
                contextpers.Weapon = weapon;
                contextpers.P_damage = contextpers.P_damage + 10;
                contextpers.Strenght = contextpers.Strenght + 10;
                contextpers.Crt_chanse = contextpers.Crt_chanse + (contextpers.Crt_chanse / 100 * 20);
                contextpers.Crt_damage = contextpers.Crt_damage + (contextpers.Crt_damage / 100 * 170);
            }
            else if (weaponcontext == "Rare Dagger")
            {
                Weapon weapon = new Weapon("Rare Dagger", "Rare");
                contextpers.Weapon = weapon;
                contextpers.Dextenity = contextpers.Dextenity + 6;
                contextpers.P_damage = contextpers.P_damage + 6;
                contextpers.Crt_chanse = contextpers.Crt_chanse + (contextpers.Crt_chanse / 100 * 70);
                contextpers.Crt_damage = contextpers.Crt_damage + (contextpers.Crt_damage / 100 * 70);
                contextpers.Inteligence = contextpers.Inteligence + 5;
            }
            MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
            DataContext = contextpers;
            var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
            var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
            NavigationService.Navigate(new InfoHeroRogue(persRogue));
        }

        private void NameTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            contextpers.Name = NameTB.Text;
            MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
            DataContext = contextpers;
            //var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
            //var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
            //NavigationService.Navigate(new InfoHeroRogue(persRogue));
        }

        //private void SetInitialValueFromDatabase()
        //{
        //    // Получение значения из базы данных (пример работы с БД)
        //    string weaponName = contextpers.Weapon.Name; // Ваш метод для получения значения из БД

        //    // Находим соответствующий элемент в ComboBox и устанавливаем его в качестве выбранного
        //    TextBlock selectedTextBlock = null;
        //    foreach (TextBlock item in WeaponCB.Items)
        //    {
        //        if (item.Text == weaponName)
        //        {
        //            selectedTextBlock = item;
        //            break;
        //        }
        //    }

        //    if (selectedTextBlock != null)
        //    {
        //        WeaponCB.SelectedItem = selectedTextBlock; // Устанавливаем выбранный элемент
        //    }
        //    else
        //    {
        //        // В случае, если значение из базы данных отсутствует или равно null
        //        // Можно установить какое-то дефолтное значение, например первый элемент
        //        WeaponCB.SelectedItem = "Не выбрано";
        //    }
        //}

        //private void Page_Loaded(object sender, RoutedEventArgs e)
        //{
        //    SetInitialValueFromDatabase(); // Вызываем метод для установки начального значения из базы данных
        //}

        
    }
}
