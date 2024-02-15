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
    /// Логика взаимодействия для WeaponChoosePage.xaml
    /// </summary>
    public partial class WeaponChoosePage : Page
    {
        Character contextpers {  get; set; }
        public WeaponChoosePage(Character character)
        {
            InitializeComponent();
            contextpers = character;
            this.DataContext = contextpers;
        }

        private void WandBT_Click(object sender, RoutedEventArgs e)
        {
            
            if (contextpers.Weapon == null)
            {
                Weapon weapon = new Weapon("Wand", "Common");
                contextpers.Weapon = weapon;
                contextpers.Inteligence = contextpers.Inteligence + 5;
                contextpers.P_damage = contextpers.P_damage + 2;
                contextpers.Mana = contextpers.Mana + 5;
                MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                DataContext = contextpers;
                var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                NavigationService.Navigate(new InfoHeroRogue(persRogue));
            }
            else
            {
                if (contextpers.Weapon.Name == "Wand")
                {
                    MessageBox.Show("Оружие уже выбрано");
                }
                else 
                {
                    if (contextpers.Weapon.Name == "Dagger")
                    {
                        contextpers.Dextenity = contextpers.Dextenity - 4;
                        contextpers.P_damage = contextpers.P_damage - 3;
                        contextpers.Crt_chanse = contextpers.Crt_chanse / 1.6;
                        contextpers.Crt_damage = contextpers.Crt_damage / 1.7;
                    }
                    if (contextpers.Weapon.Name == "Rare Dagger")
                    {
                        contextpers.Dextenity = contextpers.Dextenity - 6;
                        contextpers.P_damage = contextpers.P_damage - 6;
                        contextpers.Crt_chanse = contextpers.Crt_chanse / 1.7;
                        contextpers.Crt_damage = contextpers.Crt_damage / 1.7;
                        contextpers.Inteligence = contextpers.Inteligence - 5;
                    }
                    if (contextpers.Weapon.Name == "Axe")
                    {
                        contextpers.P_damage = contextpers.P_damage - 10;
                        contextpers.Strenght = contextpers.Strenght - 10;
                        contextpers.Crt_chanse = contextpers.Crt_chanse / 1.2;
                        contextpers.Crt_damage = contextpers.Crt_damage / 2.7;
                    }
                    contextpers.Weapon = null;
                    Weapon weapon = new Weapon("Wand", "Common");
                    contextpers.Weapon = weapon;
                    contextpers.Inteligence = contextpers.Inteligence + 5;
                    contextpers.P_damage = contextpers.P_damage + 2;
                    contextpers.Mana = contextpers.Mana + 5;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    DataContext = contextpers;
                    
                }
                var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                NavigationService.Navigate(new InfoHeroRogue(persRogue));

            }
            
        }

        private void MagicWandBT_Click(object sender, RoutedEventArgs e)
        {
            if(contextpers.BaseName == "Rogue")
            {
                MessageBox.Show("К сожалению, вам недоступно данное оружие");
            }
        }

        private void DaggerBT_Click(object sender, RoutedEventArgs e)
        {
            
            if (contextpers.Weapon.Name == null)
            {
                Weapon weapon = new Weapon("Dagger", "Common");
                contextpers.Weapon = weapon;
                contextpers.Dextenity = contextpers.Dextenity + 4;
                contextpers.P_damage = contextpers.P_damage + 3;
                contextpers.Crt_chanse = contextpers.Crt_chanse * 1.6;
                contextpers.Crt_damage = contextpers.Crt_damage * 1.6;
                MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                DataContext = contextpers;
                var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                NavigationService.Navigate(new InfoHeroRogue(persRogue));
            }
           
            else
            {
                if (contextpers.Weapon.Name == "Dagger")
                {
                    MessageBox.Show("Данное оружие уже выбрано");
                }
                else
                {
                    if (contextpers.Weapon.Name == "Rare Dagger")
                    {
                        contextpers.Dextenity = contextpers.Dextenity - 6;
                        contextpers.P_damage = contextpers.P_damage - 6;
                        contextpers.Crt_chanse = contextpers.Crt_chanse / 1.7;
                        contextpers.Crt_damage = contextpers.Crt_damage / 1.7;
                        contextpers.Inteligence = contextpers.Inteligence - 5;
                    }
                    if (contextpers.Weapon.Name == "Axe")
                    {
                        contextpers.P_damage = contextpers.P_damage - 10;
                        contextpers.Strenght = contextpers.Strenght - 10;
                        contextpers.Crt_chanse = contextpers.Crt_chanse / 1.2;
                        contextpers.Crt_damage = contextpers.Crt_damage / 2.7;
                    }
                    if (contextpers.Weapon.Name == "Wand")
                    {
                        contextpers.Inteligence = contextpers.Inteligence - 5;
                        contextpers.P_damage = contextpers.P_damage - 2;
                        contextpers.Mana = contextpers.Mana - 5;
                    }
                    contextpers.Weapon = null;
                    Weapon weapon = new Weapon("Dagger", "Common");
                    contextpers.Weapon = weapon;
                    contextpers.Dextenity = contextpers.Dextenity + 4;
                    contextpers.P_damage = contextpers.P_damage + 3;
                    contextpers.Crt_chanse = contextpers.Crt_chanse * 1.6;
                    contextpers.Crt_damage = contextpers.Crt_damage * 1.6;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    DataContext = contextpers;
                }             
                var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                NavigationService.Navigate(new InfoHeroRogue(persRogue));
            }
            
        }

        private void RareDaggerBT_Click(object sender, RoutedEventArgs e)
        {
            
            if (contextpers.Weapon.Name == null)
            {
                Weapon weapon = new Weapon("Rare Dagger", "Rare");
                contextpers.Weapon = weapon;
                contextpers.Dextenity = contextpers.Dextenity + 6;
                contextpers.P_damage = contextpers.P_damage + 6;
                contextpers.Crt_chanse = contextpers.Crt_chanse * 1.7;
                contextpers.Crt_damage = contextpers.Crt_damage * 1.7;
                contextpers.Inteligence = contextpers.Inteligence + 5;
                MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                DataContext = contextpers;
                var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                NavigationService.Navigate(new InfoHeroRogue(persRogue));
            }
            
            else
            {
                if (contextpers.Weapon.Name == "Rare Dagger")
                {
                    MessageBox.Show("Данное оружие уже выбрано");
                }
                else
                {
                    if (contextpers.Weapon.Name == "Axe")
                    {
                        contextpers.P_damage = contextpers.P_damage - 10;
                        contextpers.Strenght = contextpers.Strenght - 10;
                        contextpers.Crt_chanse = contextpers.Crt_chanse / 1.2;
                        contextpers.Crt_damage = contextpers.Crt_damage / 2.7;
                    }
                    if (contextpers.Weapon.Name == "Wand")
                    {
                        contextpers.Inteligence = contextpers.Inteligence - 5;
                        contextpers.P_damage = contextpers.P_damage - 2;
                        contextpers.Mana = contextpers.Mana - 5;
                    }
                    if (contextpers.Weapon.Name == "Dagger")
                    {
                        contextpers.Dextenity = contextpers.Dextenity - 4;
                        contextpers.P_damage = contextpers.P_damage - 3;
                        contextpers.Crt_chanse = contextpers.Crt_chanse / 1.6;
                        contextpers.Crt_damage = contextpers.Crt_damage / 1.7;
                    }
                    contextpers.Weapon = null;
                    Weapon weapon = new Weapon("Rare Dagger", "Rare");
                    contextpers.Weapon = weapon;
                    contextpers.Dextenity = contextpers.Dextenity + 6;
                    contextpers.P_damage = contextpers.P_damage + 6;
                    contextpers.Crt_chanse = contextpers.Crt_chanse * 1.7;
                    contextpers.Crt_damage = contextpers.Crt_damage * 1.7;
                    contextpers.Inteligence = contextpers.Inteligence + 5;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    DataContext = contextpers;
                }
                
                var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                NavigationService.Navigate(new InfoHeroRogue(persRogue));
            }
            
        }

        private void SwordBT_Click(object sender, RoutedEventArgs e)
        {
            if (contextpers.BaseName == "Rogue")
            {
                MessageBox.Show("К сожалению, вам недоступно данное оружие");
            }
        }

        private void RareSwordBT_Click(object sender, RoutedEventArgs e)
        {
            if (contextpers.BaseName == "Rogue")
            {
                MessageBox.Show("К сожалению, вам недоступно данное оружие");
            }
        }

        private void AxeBT_Click(object sender, RoutedEventArgs e)
        {
          
            if (contextpers.Weapon.Name == null)
            {
                Weapon weapon = new Weapon("Axe", "Common");
                contextpers.Weapon = weapon;
                contextpers.P_damage = contextpers.P_damage + 10;
                contextpers.Strenght = contextpers.Strenght + 10;
                contextpers.Crt_chanse = contextpers.Crt_chanse * 1.2;
                contextpers.Crt_damage = contextpers.Crt_damage * 2.7;
                MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                DataContext = contextpers;
                var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                NavigationService.Navigate(new InfoHeroRogue(persRogue));
            }
            
            else
            {
                if (contextpers.Weapon.Name == "Axe")
                {
                    MessageBox.Show("Данное оружие уже выбрано");
                }
                else
                {
                    if (contextpers.Weapon.Name == "Wand")
                    {
                        contextpers.Inteligence = contextpers.Inteligence - 5;
                        contextpers.P_damage = contextpers.P_damage - 2;
                        contextpers.Mana = contextpers.Mana - 5;
                    }
                    if (contextpers.Weapon.Name == "Dagger")
                    {
                        contextpers.Dextenity = contextpers.Dextenity - 4;
                        contextpers.P_damage = contextpers.P_damage - 3;
                        contextpers.Crt_chanse = contextpers.Crt_chanse / 1.6;
                        contextpers.Crt_damage = contextpers.Crt_damage / 1.7;
                    }
                    if (contextpers.Weapon.Name == "Rare Dagger")
                    {
                        contextpers.Dextenity = contextpers.Dextenity - 6;
                        contextpers.P_damage = contextpers.P_damage - 6;
                        contextpers.Crt_chanse = contextpers.Crt_chanse / 1.7;
                        contextpers.Crt_damage = contextpers.Crt_damage / 1.7;
                        contextpers.Inteligence = contextpers.Inteligence - 5;
                    }
                    contextpers.Weapon = null;
                    Weapon weapon = new Weapon("Axe", "Common");
                    contextpers.Weapon = weapon;
                    contextpers.P_damage = contextpers.P_damage + 10;
                    contextpers.Strenght = contextpers.Strenght + 10;
                    contextpers.Crt_chanse = contextpers.Crt_chanse * 1.2;
                    contextpers.Crt_damage = contextpers.Crt_damage / 2.7;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    DataContext = contextpers;
                }
                
                var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                NavigationService.Navigate(new InfoHeroRogue(persRogue));
            }
            
        }

        private void HammerBT_Click(object sender, RoutedEventArgs e)
        {
            if (contextpers.BaseName == "Rogue")
            {
                MessageBox.Show("К сожалению, вам недоступно данное оружие");
            }
        }

        private void RareHammerBT_Click(object sender, RoutedEventArgs e)
        {
            if (contextpers.BaseName == "Rogue")
            {
                MessageBox.Show("К сожалению, вам недоступно данное оружие");
            }
        }

        private void TwoHandedBT_Click(object sender, RoutedEventArgs e)
        {
            if (contextpers.BaseName == "Rogue")
            {
                MessageBox.Show("К сожалению, вам недоступно данное оружие");
            }
        }
    }
}
