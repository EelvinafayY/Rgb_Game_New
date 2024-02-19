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
                Wand weapon = new Wand("Common");
                contextpers.Weapon = weapon;
                MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                contextpers.Inteligence += weapon.Inteligence;
                contextpers.Dextenity += weapon.Dexterity;
                contextpers.Strenght += weapon.Strength;
                contextpers.Vitality += weapon.Vitality;
                contextpers.Health += weapon.Health;
                contextpers.Mana += weapon.Mana;
                contextpers.P_damage += weapon.P_damage;
                contextpers.Armor += weapon.Armor;
                contextpers.M_damage += weapon.M_damage;
                contextpers.M_defense += weapon.M_defense;
                contextpers.Crt_chanse *= weapon.Crt_chanse;
                contextpers.Crt_damage *= weapon.Crt_damage;
                contextpers.ShieldAvailable = weapon.ShieldAvailable;
                DataContext = contextpers;
                MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);  
            }
            else
            {
                if (contextpers.Weapon.Name == "Wand")
                {
                    MessageBox.Show("Оружие уже выбрано");
                }
                else 
                {
                    contextpers.Inteligence -= contextpers.Weapon.Inteligence;
                    contextpers.Dextenity -= contextpers.Weapon.Dexterity;
                    contextpers.Strenght -= contextpers.Weapon.Strength;
                    contextpers.Vitality -= contextpers.Weapon.Vitality;
                    contextpers.Health -= contextpers.Weapon.Health;
                    contextpers.Mana -= contextpers.Weapon.Mana;
                    contextpers.P_damage -= contextpers.Weapon.P_damage;
                    contextpers.Armor -= contextpers.Weapon.Armor;
                    contextpers.M_damage -= contextpers.Weapon.M_damage;
                    contextpers.M_defense -= contextpers.Weapon.M_defense;
                    contextpers.Crt_chanse /= contextpers.Weapon.Crt_chanse;
                    contextpers.Crt_damage /= contextpers.Weapon.Crt_damage;
                    contextpers.ShieldAvailable = true;
                    contextpers.Weapon = null;
                    Wand weapon = new Wand("Common");
                    contextpers.Weapon = weapon;
                    contextpers.Inteligence += weapon.Inteligence;
                    contextpers.Dextenity += weapon.Dexterity;
                    contextpers.Strenght += weapon.Strength;
                    contextpers.Vitality += weapon.Vitality;
                    contextpers.Health += weapon.Health;
                    contextpers.Mana += weapon.Mana;
                    contextpers.P_damage += weapon.P_damage;
                    contextpers.Armor += weapon.Armor;
                    contextpers.M_damage += weapon.M_damage;
                    contextpers.M_defense += weapon.M_defense;
                    contextpers.Crt_chanse *= weapon.Crt_chanse;
                    contextpers.Crt_damage *= weapon.Crt_damage;
                    contextpers.ShieldAvailable = weapon.ShieldAvailable;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    DataContext = contextpers;
                    
                }
                

            }
            if (contextpers.BaseName == "Rogue")
            {
                var persesRogue = MongoDBConnection.GetRogue("Rogue");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                NavigationService.Navigate(new InfoHeroRogue(persRogue));
            }
            if (contextpers.BaseName == "Wizard")
            {
                var persesRogue = MongoDBConnection.GetWizard("Wizard");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                NavigationService.Navigate(new InfoWizardPage(persRogue));
            }
            if (contextpers.BaseName == "Warrior")
            {
                var persesRogue = MongoDBConnection.GetWarrior("Warrior");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                NavigationService.Navigate(new InfoWarriorPage(persRogue));
            }

        }

        private void MagicWandBT_Click(object sender, RoutedEventArgs e)
        {
            if(contextpers.Level <= 10)
            {
                MessageBox.Show("К сожалению, ваш уровень не подходит для данного оружия");
            }
            else
            {
                if (contextpers.Weapon == null)
                {
                    Wand weapon = new Wand("Enchanted");
                    contextpers.Weapon = weapon;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    contextpers.Inteligence += weapon.Inteligence;
                    contextpers.Dextenity += weapon.Dexterity;
                    contextpers.Strenght += weapon.Strength;
                    contextpers.Vitality += weapon.Vitality;
                    contextpers.Health += weapon.Health;
                    contextpers.Mana += weapon.Mana;
                    contextpers.P_damage += weapon.P_damage;
                    contextpers.Armor += weapon.Armor;
                    contextpers.M_damage += weapon.M_damage;
                    contextpers.M_defense += weapon.M_defense;
                    contextpers.Crt_chanse *= weapon.Crt_chanse;
                    contextpers.Crt_damage *= weapon.Crt_damage;
                    contextpers.ShieldAvailable = weapon.ShieldAvailable;
                    DataContext = contextpers;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoHeroRogue(persRogue));

                }
                else
                {
                    if (contextpers.Weapon.Name == "Enchanted Wand")
                    {
                        MessageBox.Show("Оружие уже выбрано");
                    }
                    else
                    {
                        contextpers.Inteligence -= contextpers.Weapon.Inteligence;
                        contextpers.Dextenity -= contextpers.Weapon.Dexterity;
                        contextpers.Strenght -= contextpers.Weapon.Strength;
                        contextpers.Vitality -= contextpers.Weapon.Vitality;
                        contextpers.Health -= contextpers.Weapon.Health;
                        contextpers.Mana -= contextpers.Weapon.Mana;
                        contextpers.P_damage -= contextpers.Weapon.P_damage;
                        contextpers.Armor -= contextpers.Weapon.Armor;
                        contextpers.M_damage -= contextpers.Weapon.M_damage;
                        contextpers.M_defense -= contextpers.Weapon.M_defense;
                        contextpers.Crt_chanse /= contextpers.Weapon.Crt_chanse;
                        contextpers.Crt_damage /= contextpers.Weapon.Crt_damage;
                        contextpers.ShieldAvailable = true;
                        contextpers.Weapon = null;
                        Wand weapon = new Wand("Enchanted");
                        contextpers.Weapon = weapon;
                        contextpers.Inteligence += weapon.Inteligence;
                        contextpers.Dextenity += weapon.Dexterity;
                        contextpers.Strenght += weapon.Strength;
                        contextpers.Vitality += weapon.Vitality;
                        contextpers.Health += weapon.Health;
                        contextpers.Mana += weapon.Mana;
                        contextpers.P_damage += weapon.P_damage;
                        contextpers.Armor += weapon.Armor;
                        contextpers.M_damage += weapon.M_damage;
                        contextpers.M_defense += weapon.M_defense;
                        contextpers.Crt_chanse *= weapon.Crt_chanse;
                        contextpers.Crt_damage *= weapon.Crt_damage;
                        contextpers.ShieldAvailable = weapon.ShieldAvailable;
                        MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                        DataContext = contextpers;

                    } 
                }

                if (contextpers.BaseName == "Rogue")
                {
                    var persesRogue = MongoDBConnection.GetRogue("Rogue");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoHeroRogue(persRogue));
                }
                if (contextpers.BaseName == "Wizard")
                {
                    var persesRogue = MongoDBConnection.GetWizard("Wizard");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoWizardPage(persRogue));
                }
                if (contextpers.BaseName == "Warrior")
                {
                    var persesRogue = MongoDBConnection.GetWarrior("Warrior");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoWarriorPage(persRogue));
                }
            }
        }

        

        private void RareWandBT_Click(object sender, RoutedEventArgs e)
        {
            if (contextpers.Level <= 30)
            {
                MessageBox.Show("К сожалению, ваш уровень не подходит для данного оружия");
            }
            else
            {
                if (contextpers.Weapon == null)
                {
                    Wand weapon = new Wand("Rare");
                    contextpers.Weapon = weapon;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    contextpers.Inteligence += weapon.Inteligence;
                    contextpers.Dextenity += weapon.Dexterity;
                    contextpers.Strenght += weapon.Strength;
                    contextpers.Vitality += weapon.Vitality;
                    contextpers.Health += weapon.Health;
                    contextpers.Mana += weapon.Mana;
                    contextpers.P_damage += weapon.P_damage;
                    contextpers.Armor += weapon.Armor;
                    contextpers.M_damage += weapon.M_damage;
                    contextpers.M_defense += weapon.M_defense;
                    contextpers.Crt_chanse *= weapon.Crt_chanse;
                    contextpers.Crt_damage *= weapon.Crt_damage;
                    contextpers.ShieldAvailable = weapon.ShieldAvailable;
                    DataContext = contextpers;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoHeroRogue(persRogue));

                }
                else
                {
                    if (contextpers.Weapon.Name == "Rare Wand")
                    {
                        MessageBox.Show("Оружие уже выбрано");
                    }
                    else
                    {
                        contextpers.Inteligence -= contextpers.Weapon.Inteligence;
                        contextpers.Dextenity -= contextpers.Weapon.Dexterity;
                        contextpers.Strenght -= contextpers.Weapon.Strength;
                        contextpers.Vitality -= contextpers.Weapon.Vitality;
                        contextpers.Health -= contextpers.Weapon.Health;
                        contextpers.Mana -= contextpers.Weapon.Mana;
                        contextpers.P_damage -= contextpers.Weapon.P_damage;
                        contextpers.Armor -= contextpers.Weapon.Armor;
                        contextpers.M_damage -= contextpers.Weapon.M_damage;
                        contextpers.M_defense -= contextpers.Weapon.M_defense;
                        contextpers.Crt_chanse /= contextpers.Weapon.Crt_chanse;
                        contextpers.Crt_damage /= contextpers.Weapon.Crt_damage;
                        contextpers.ShieldAvailable = true;
                        contextpers.Weapon = null;
                        Wand weapon = new Wand("Rare");
                        contextpers.Weapon = weapon;
                        contextpers.Inteligence += weapon.Inteligence;
                        contextpers.Dextenity += weapon.Dexterity;
                        contextpers.Strenght += weapon.Strength;
                        contextpers.Vitality += weapon.Vitality;
                        contextpers.Health += weapon.Health;
                        contextpers.Mana += weapon.Mana;
                        contextpers.P_damage += weapon.P_damage;
                        contextpers.Armor += weapon.Armor;
                        contextpers.M_damage += weapon.M_damage;
                        contextpers.M_defense += weapon.M_defense;
                        contextpers.Crt_chanse *= weapon.Crt_chanse;
                        contextpers.Crt_damage *= weapon.Crt_damage;
                        contextpers.ShieldAvailable = weapon.ShieldAvailable;
                        MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                        DataContext = contextpers;

                    }
                }
                if (contextpers.BaseName == "Rogue")
                {
                    var persesRogue = MongoDBConnection.GetRogue("Rogue");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoHeroRogue(persRogue));
                }
                if (contextpers.BaseName == "Wizard")
                {
                    var persesRogue = MongoDBConnection.GetWizard("Wizard");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoWizardPage(persRogue));
                }
                if (contextpers.BaseName == "Warrior")
                {
                    var persesRogue = MongoDBConnection.GetWarrior("Warrior");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoWarriorPage(persRogue));
                }
            }
        }

        private void DaggerBT_Click(object sender, RoutedEventArgs e)
        {
            if (contextpers.Weapon == null)
            {
                Dagger weapon = new Dagger("Common");
                contextpers.Weapon = weapon;
                MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                contextpers.Inteligence += weapon.Inteligence;
                contextpers.Dextenity += weapon.Dexterity;
                contextpers.Strenght += weapon.Strength;
                contextpers.Vitality += weapon.Vitality;
                contextpers.Health += weapon.Health;
                contextpers.Mana += weapon.Mana;
                contextpers.P_damage += weapon.P_damage;
                contextpers.Armor += weapon.Armor;
                contextpers.M_damage += weapon.M_damage;
                contextpers.M_defense += weapon.M_defense;
                contextpers.Crt_chanse *= weapon.Crt_chanse;
                contextpers.Crt_damage *= weapon.Crt_damage;
                contextpers.ShieldAvailable = weapon.ShieldAvailable;
                DataContext = contextpers;
                MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
            }
            else
            {
                if (contextpers.Weapon.Name == "Dagger")
                {
                    MessageBox.Show("Оружие уже выбрано");
                }
                else
                {
                    contextpers.Inteligence -= contextpers.Weapon.Inteligence;
                    contextpers.Dextenity -= contextpers.Weapon.Dexterity;
                    contextpers.Strenght -= contextpers.Weapon.Strength;
                    contextpers.Vitality -= contextpers.Weapon.Vitality;
                    contextpers.Health -= contextpers.Weapon.Health;
                    contextpers.Mana -= contextpers.Weapon.Mana;
                    contextpers.P_damage -= contextpers.Weapon.P_damage;
                    contextpers.Armor -= contextpers.Weapon.Armor;
                    contextpers.M_damage -= contextpers.Weapon.M_damage;
                    contextpers.M_defense -= contextpers.Weapon.M_defense;
                    contextpers.Crt_chanse /= contextpers.Weapon.Crt_chanse;
                    contextpers.Crt_damage /= contextpers.Weapon.Crt_damage;
                    contextpers.ShieldAvailable = true;
                    contextpers.Weapon = null;
                    Dagger weapon = new Dagger("Common");
                    contextpers.Weapon = weapon;
                    contextpers.Inteligence += weapon.Inteligence;
                    contextpers.Dextenity += weapon.Dexterity;
                    contextpers.Strenght += weapon.Strength;
                    contextpers.Vitality += weapon.Vitality;
                    contextpers.Health += weapon.Health;
                    contextpers.Mana += weapon.Mana;
                    contextpers.P_damage += weapon.P_damage;
                    contextpers.Armor += weapon.Armor;
                    contextpers.M_damage += weapon.M_damage;
                    contextpers.M_defense += weapon.M_defense;
                    contextpers.Crt_chanse *= weapon.Crt_chanse;
                    contextpers.Crt_damage *= weapon.Crt_damage;
                    contextpers.ShieldAvailable = weapon.ShieldAvailable;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    DataContext = contextpers;

                }


            }
            if (contextpers.BaseName == "Rogue")
            {
                var persesRogue = MongoDBConnection.GetRogue("Rogue");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                NavigationService.Navigate(new InfoHeroRogue(persRogue));
            }
            if (contextpers.BaseName == "Wizard")
            {
                var persesRogue = MongoDBConnection.GetWizard("Wizard");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                NavigationService.Navigate(new InfoWizardPage(persRogue));
            }
            if (contextpers.BaseName == "Warrior")
            {
                var persesRogue = MongoDBConnection.GetWarrior("Warrior");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                NavigationService.Navigate(new InfoWarriorPage(persRogue));
            }
        }

        private void MagicDaggerBT_Click(object sender, RoutedEventArgs e)
        {
            if (contextpers.Level <= 10)
            {
                MessageBox.Show("К сожалению, ваш уровень не подходит для данного оружия");
            }
            else
            {
                if (contextpers.Weapon == null)
                {
                    Dagger weapon = new Dagger("Enchanted");
                    contextpers.Weapon = weapon;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    contextpers.Inteligence += weapon.Inteligence;
                    contextpers.Dextenity += weapon.Dexterity;
                    contextpers.Strenght += weapon.Strength;
                    contextpers.Vitality += weapon.Vitality;
                    contextpers.Health += weapon.Health;
                    contextpers.Mana += weapon.Mana;
                    contextpers.P_damage += weapon.P_damage;
                    contextpers.Armor += weapon.Armor;
                    contextpers.M_damage += weapon.M_damage;
                    contextpers.M_defense += weapon.M_defense;
                    contextpers.Crt_chanse *= weapon.Crt_chanse;
                    contextpers.Crt_damage *= weapon.Crt_damage;
                    contextpers.ShieldAvailable = weapon.ShieldAvailable;
                    DataContext = contextpers;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoHeroRogue(persRogue));

                }
                else
                {
                    if (contextpers.Weapon.Name == "Enchanted Dagger")
                    {
                        MessageBox.Show("Оружие уже выбрано");
                    }
                    else
                    {
                        contextpers.Inteligence -= contextpers.Weapon.Inteligence;
                        contextpers.Dextenity -= contextpers.Weapon.Dexterity;
                        contextpers.Strenght -= contextpers.Weapon.Strength;
                        contextpers.Vitality -= contextpers.Weapon.Vitality;
                        contextpers.Health -= contextpers.Weapon.Health;
                        contextpers.Mana -= contextpers.Weapon.Mana;
                        contextpers.P_damage -= contextpers.Weapon.P_damage;
                        contextpers.Armor -= contextpers.Weapon.Armor;
                        contextpers.M_damage -= contextpers.Weapon.M_damage;
                        contextpers.M_defense -= contextpers.Weapon.M_defense;
                        contextpers.Crt_chanse /= contextpers.Weapon.Crt_chanse;
                        contextpers.Crt_damage /= contextpers.Weapon.Crt_damage;
                        contextpers.ShieldAvailable = true;
                        contextpers.Weapon = null;
                        Dagger weapon = new Dagger("Enchanted");
                        contextpers.Weapon = weapon;
                        contextpers.Inteligence += weapon.Inteligence;
                        contextpers.Dextenity += weapon.Dexterity;
                        contextpers.Strenght += weapon.Strength;
                        contextpers.Vitality += weapon.Vitality;
                        contextpers.Health += weapon.Health;
                        contextpers.Mana += weapon.Mana;
                        contextpers.P_damage += weapon.P_damage;
                        contextpers.Armor += weapon.Armor;
                        contextpers.M_damage += weapon.M_damage;
                        contextpers.M_defense += weapon.M_defense;
                        contextpers.Crt_chanse *= weapon.Crt_chanse;
                        contextpers.Crt_damage *= weapon.Crt_damage;
                        contextpers.ShieldAvailable = weapon.ShieldAvailable;
                        MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                        DataContext = contextpers;

                    }
                }
                if (contextpers.BaseName == "Rogue")
                {
                    var persesRogue = MongoDBConnection.GetRogue("Rogue");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoHeroRogue(persRogue));
                }
                if (contextpers.BaseName == "Wizard")
                {
                    var persesRogue = MongoDBConnection.GetWizard("Wizard");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoWizardPage(persRogue));
                }
                if (contextpers.BaseName == "Warrior")
                {
                    var persesRogue = MongoDBConnection.GetWarrior("Warrior");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoWarriorPage(persRogue));
                }
            }
        }

        private void RareDaggerBT_Click(object sender, RoutedEventArgs e)
        {
            if (contextpers.Level <= 30)
            {
                MessageBox.Show("К сожалению, ваш уровень не подходит для данного оружия");
            }
            else
            {
                if (contextpers.Weapon == null)
                {
                    Dagger weapon = new Dagger("Rare");
                    contextpers.Weapon = weapon;
                    contextpers.Inteligence += weapon.Inteligence;
                    contextpers.Dextenity += weapon.Dexterity;
                    contextpers.Strenght += weapon.Strength;
                    contextpers.Vitality += weapon.Vitality;
                    contextpers.Health += weapon.Health;
                    contextpers.Mana += weapon.Mana;
                    contextpers.P_damage += weapon.P_damage;
                    contextpers.Armor += weapon.Armor;
                    contextpers.M_damage += weapon.M_damage;
                    contextpers.M_defense += weapon.M_defense;
                    contextpers.Crt_chanse *= weapon.Crt_chanse;
                    contextpers.Crt_damage *= weapon.Crt_damage;
                    contextpers.ShieldAvailable = weapon.ShieldAvailable;
                    DataContext = contextpers;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoHeroRogue(persRogue));

                }
                else
                {
                    if (contextpers.Weapon.Name == "Rare Dagger")
                    {
                        MessageBox.Show("Оружие уже выбрано");
                    }
                    else
                    {
                        contextpers.Inteligence -= contextpers.Weapon.Inteligence;
                        contextpers.Dextenity -= contextpers.Weapon.Dexterity;
                        contextpers.Strenght -= contextpers.Weapon.Strength;
                        contextpers.Vitality -= contextpers.Weapon.Vitality;
                        contextpers.Health -= contextpers.Weapon.Health;
                        contextpers.Mana -= contextpers.Weapon.Mana;
                        contextpers.P_damage -= contextpers.Weapon.P_damage;
                        contextpers.Armor -= contextpers.Weapon.Armor;
                        contextpers.M_damage -= contextpers.Weapon.M_damage;
                        contextpers.M_defense -= contextpers.Weapon.M_defense;
                        contextpers.Crt_chanse /= contextpers.Weapon.Crt_chanse;
                        contextpers.Crt_damage /= contextpers.Weapon.Crt_damage;
                        contextpers.ShieldAvailable = true;
                        contextpers.Weapon = null;
                        Dagger weapon = new Dagger("Rare");
                        contextpers.Weapon = weapon;
                        contextpers.Inteligence += weapon.Inteligence;
                        contextpers.Dextenity += weapon.Dexterity;
                        contextpers.Strenght += weapon.Strength;
                        contextpers.Vitality += weapon.Vitality;
                        contextpers.Health += weapon.Health;
                        contextpers.Mana += weapon.Mana;
                        contextpers.P_damage += weapon.P_damage;
                        contextpers.Armor += weapon.Armor;
                        contextpers.M_damage += weapon.M_damage;
                        contextpers.M_defense += weapon.M_defense;
                        contextpers.Crt_chanse *= weapon.Crt_chanse;
                        contextpers.Crt_damage *= weapon.Crt_damage;
                        contextpers.ShieldAvailable = weapon.ShieldAvailable;
                        MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                        DataContext = contextpers;

                    }
                }
                if (contextpers.BaseName == "Rogue")
                {
                    var persesRogue = MongoDBConnection.GetRogue("Rogue");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoHeroRogue(persRogue));
                }
                if (contextpers.BaseName == "Wizard")
                {
                    var persesRogue = MongoDBConnection.GetWizard("Wizard");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoWizardPage(persRogue));
                }
                if (contextpers.BaseName == "Warrior")
                {
                    var persesRogue = MongoDBConnection.GetWarrior("Warrior");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoWarriorPage(persRogue));
                }
            }
        }

        private void SwordBT_Click(object sender, RoutedEventArgs e)
        {
            if (contextpers.Weapon == null)
            {
                Sword weapon = new Sword("Common");
                contextpers.Weapon = weapon;
                MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                contextpers.Inteligence += weapon.Inteligence;
                contextpers.Dextenity += weapon.Dexterity;
                contextpers.Strenght += weapon.Strength;
                contextpers.Vitality += weapon.Vitality;
                contextpers.Health += weapon.Health;
                contextpers.Mana += weapon.Mana;
                contextpers.P_damage += weapon.P_damage;
                contextpers.Armor += weapon.Armor;
                contextpers.M_damage += weapon.M_damage;
                contextpers.M_defense += weapon.M_defense;
                contextpers.Crt_chanse *= weapon.Crt_chanse;
                contextpers.Crt_damage *= weapon.Crt_damage;
                contextpers.ShieldAvailable = weapon.ShieldAvailable;
                DataContext = contextpers;
                MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
            }
            else
            {
                if (contextpers.Weapon.Name == "Sword")
                {
                    MessageBox.Show("Оружие уже выбрано");
                }
                else
                {
                    contextpers.Inteligence -= contextpers.Weapon.Inteligence;
                    contextpers.Dextenity -= contextpers.Weapon.Dexterity;
                    contextpers.Strenght -= contextpers.Weapon.Strength;
                    contextpers.Vitality -= contextpers.Weapon.Vitality;
                    contextpers.Health -= contextpers.Weapon.Health;
                    contextpers.Mana -= contextpers.Weapon.Mana;
                    contextpers.P_damage -= contextpers.Weapon.P_damage;
                    contextpers.Armor -= contextpers.Weapon.Armor;
                    contextpers.M_damage -= contextpers.Weapon.M_damage;
                    contextpers.M_defense -= contextpers.Weapon.M_defense;
                    contextpers.Crt_chanse /= contextpers.Weapon.Crt_chanse;
                    contextpers.Crt_damage /= contextpers.Weapon.Crt_damage;
                    contextpers.ShieldAvailable = true;
                    contextpers.Weapon = null;
                    Sword weapon = new Sword("Common");
                    contextpers.Weapon = weapon;
                    contextpers.Inteligence += weapon.Inteligence;
                    contextpers.Dextenity += weapon.Dexterity;
                    contextpers.Strenght += weapon.Strength;
                    contextpers.Vitality += weapon.Vitality;
                    contextpers.Health += weapon.Health;
                    contextpers.Mana += weapon.Mana;
                    contextpers.P_damage += weapon.P_damage;
                    contextpers.Armor += weapon.Armor;
                    contextpers.M_damage += weapon.M_damage;
                    contextpers.M_defense += weapon.M_defense;
                    contextpers.Crt_chanse *= weapon.Crt_chanse;
                    contextpers.Crt_damage *= weapon.Crt_damage;
                    contextpers.ShieldAvailable = weapon.ShieldAvailable;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    DataContext = contextpers;

                }


            }
            if (contextpers.BaseName == "Rogue")
            {
                var persesRogue = MongoDBConnection.GetRogue("Rogue");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                NavigationService.Navigate(new InfoHeroRogue(persRogue));
            }
            if (contextpers.BaseName == "Wizard")
            {
                var persesRogue = MongoDBConnection.GetWizard("Wizard");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                NavigationService.Navigate(new InfoWizardPage(persRogue));
            }
            if (contextpers.BaseName == "Warrior")
            {
                var persesRogue = MongoDBConnection.GetWarrior("Warrior");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                NavigationService.Navigate(new InfoWarriorPage(persRogue));
            }
        }

        private void MagicSwordBT_Click(object sender, RoutedEventArgs e)
        {
            if (contextpers.Level <= 10)
            {
                MessageBox.Show("К сожалению, ваш уровень не подходит для данного оружия");
            }
            else
            {
                if (contextpers.Weapon == null)
                {
                    Sword weapon = new Sword("Enchanted");
                    contextpers.Weapon = weapon;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    contextpers.Inteligence += weapon.Inteligence;
                    contextpers.Dextenity += weapon.Dexterity;
                    contextpers.Strenght += weapon.Strength;
                    contextpers.Vitality += weapon.Vitality;
                    contextpers.Health += weapon.Health;
                    contextpers.Mana += weapon.Mana;
                    contextpers.P_damage += weapon.P_damage;
                    contextpers.Armor += weapon.Armor;
                    contextpers.M_damage += weapon.M_damage;
                    contextpers.M_defense += weapon.M_defense;
                    contextpers.Crt_chanse *= weapon.Crt_chanse;
                    contextpers.Crt_damage *= weapon.Crt_damage;
                    contextpers.ShieldAvailable = weapon.ShieldAvailable;
                    DataContext = contextpers;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoHeroRogue(persRogue));

                }
                else
                {
                    if (contextpers.Weapon.Name == "Enchanted Sword")
                    {
                        MessageBox.Show("Оружие уже выбрано");
                    }
                    else
                    {
                        contextpers.Inteligence -= contextpers.Weapon.Inteligence;
                        contextpers.Dextenity -= contextpers.Weapon.Dexterity;
                        contextpers.Strenght -= contextpers.Weapon.Strength;
                        contextpers.Vitality -= contextpers.Weapon.Vitality;
                        contextpers.Health -= contextpers.Weapon.Health;
                        contextpers.Mana -= contextpers.Weapon.Mana;
                        contextpers.P_damage -= contextpers.Weapon.P_damage;
                        contextpers.Armor -= contextpers.Weapon.Armor;
                        contextpers.M_damage -= contextpers.Weapon.M_damage;
                        contextpers.M_defense -= contextpers.Weapon.M_defense;
                        contextpers.Crt_chanse /= contextpers.Weapon.Crt_chanse;
                        contextpers.Crt_damage /= contextpers.Weapon.Crt_damage;
                        contextpers.ShieldAvailable = true;
                        contextpers.Weapon = null;
                        Sword weapon = new Sword("Enchanted");
                        contextpers.Weapon = weapon;
                        contextpers.Inteligence += weapon.Inteligence;
                        contextpers.Dextenity += weapon.Dexterity;
                        contextpers.Strenght += weapon.Strength;
                        contextpers.Vitality += weapon.Vitality;
                        contextpers.Health += weapon.Health;
                        contextpers.Mana += weapon.Mana;
                        contextpers.P_damage += weapon.P_damage;
                        contextpers.Armor += weapon.Armor;
                        contextpers.M_damage += weapon.M_damage;
                        contextpers.M_defense += weapon.M_defense;
                        contextpers.Crt_chanse *= weapon.Crt_chanse;
                        contextpers.Crt_damage *= weapon.Crt_damage;
                        contextpers.ShieldAvailable = weapon.ShieldAvailable;
                        MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                        DataContext = contextpers;

                    }

                }
                if (contextpers.BaseName == "Rogue")
                {
                    var persesRogue = MongoDBConnection.GetRogue("Rogue");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoHeroRogue(persRogue));
                }
                if (contextpers.BaseName == "Wizard")
                {
                    var persesRogue = MongoDBConnection.GetWizard("Wizard");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoWizardPage(persRogue));
                }
                if (contextpers.BaseName == "Warrior")
                {
                    var persesRogue = MongoDBConnection.GetWarrior("Warrior");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoWarriorPage(persRogue));
                }
            }
        }

        private void RareSwordBT_Click(object sender, RoutedEventArgs e)
        {
            if (contextpers.Level <= 30)
            {
                MessageBox.Show("К сожалению, ваш уровень не подходит для данного оружия");
            }
            else
            {
                if (contextpers.Weapon == null)
                {
                    Sword weapon = new Sword("Rare");
                    contextpers.Weapon = weapon;
                    contextpers.Inteligence += weapon.Inteligence;
                    contextpers.Dextenity += weapon.Dexterity;
                    contextpers.Strenght += weapon.Strength;
                    contextpers.Vitality += weapon.Vitality;
                    contextpers.Health += weapon.Health;
                    contextpers.Mana += weapon.Mana;
                    contextpers.P_damage += weapon.P_damage;
                    contextpers.Armor += weapon.Armor;
                    contextpers.M_damage += weapon.M_damage;
                    contextpers.M_defense += weapon.M_defense;
                    contextpers.Crt_chanse *= weapon.Crt_chanse;
                    contextpers.Crt_damage *= weapon.Crt_damage;
                    contextpers.ShieldAvailable = weapon.ShieldAvailable;
                    DataContext = contextpers;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoHeroRogue(persRogue));

                }
                else
                {
                    if (contextpers.Weapon.Name == "Rare Sword")
                    {
                        MessageBox.Show("Оружие уже выбрано");
                    }
                    else
                    {
                        contextpers.Inteligence -= contextpers.Weapon.Inteligence;
                        contextpers.Dextenity -= contextpers.Weapon.Dexterity;
                        contextpers.Strenght -= contextpers.Weapon.Strength;
                        contextpers.Vitality -= contextpers.Weapon.Vitality;
                        contextpers.Health -= contextpers.Weapon.Health;
                        contextpers.Mana -= contextpers.Weapon.Mana;
                        contextpers.P_damage -= contextpers.Weapon.P_damage;
                        contextpers.Armor -= contextpers.Weapon.Armor;
                        contextpers.M_damage -= contextpers.Weapon.M_damage;
                        contextpers.M_defense -= contextpers.Weapon.M_defense;
                        contextpers.Crt_chanse /= contextpers.Weapon.Crt_chanse;
                        contextpers.Crt_damage /= contextpers.Weapon.Crt_damage;
                        contextpers.ShieldAvailable = true;
                        contextpers.Weapon = null;
                        Sword weapon = new Sword("Rare");
                        contextpers.Weapon = weapon;
                        contextpers.Inteligence += weapon.Inteligence;
                        contextpers.Dextenity += weapon.Dexterity;
                        contextpers.Strenght += weapon.Strength;
                        contextpers.Vitality += weapon.Vitality;
                        contextpers.Health += weapon.Health;
                        contextpers.Mana += weapon.Mana;
                        contextpers.P_damage += weapon.P_damage;
                        contextpers.Armor += weapon.Armor;
                        contextpers.M_damage += weapon.M_damage;
                        contextpers.M_defense += weapon.M_defense;
                        contextpers.Crt_chanse *= weapon.Crt_chanse;
                        contextpers.Crt_damage *= weapon.Crt_damage;
                        contextpers.ShieldAvailable = weapon.ShieldAvailable;
                        MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                        DataContext = contextpers;

                    }

                }
                if (contextpers.BaseName == "Rogue")
                {
                    var persesRogue = MongoDBConnection.GetRogue("Rogue");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoHeroRogue(persRogue));
                }
                if (contextpers.BaseName == "Wizard")
                {
                    var persesRogue = MongoDBConnection.GetWizard("Wizard");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoWizardPage(persRogue));
                }
                if (contextpers.BaseName == "Warrior")
                {
                    var persesRogue = MongoDBConnection.GetWarrior("Warrior");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoWarriorPage(persRogue));
                }
            }
        }

        private void AxeBT_Click(object sender, RoutedEventArgs e)
        {
            if (contextpers.Weapon == null)
            {
                Axe weapon = new Axe("Common");
                contextpers.Weapon = weapon;
                MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                contextpers.Inteligence += weapon.Inteligence;
                contextpers.Dextenity += weapon.Dexterity;
                contextpers.Strenght += weapon.Strength;
                contextpers.Vitality += weapon.Vitality;
                contextpers.Health += weapon.Health;
                contextpers.Mana += weapon.Mana;
                contextpers.P_damage += weapon.P_damage;
                contextpers.Armor += weapon.Armor;
                contextpers.M_damage += weapon.M_damage;
                contextpers.M_defense += weapon.M_defense;
                contextpers.Crt_chanse *= weapon.Crt_chanse;
                contextpers.Crt_damage *= weapon.Crt_damage;
                contextpers.ShieldAvailable = weapon.ShieldAvailable;
                DataContext = contextpers;
                MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
            }
            else
            {
                if (contextpers.Weapon.Name == "Axe")
                {
                    MessageBox.Show("Оружие уже выбрано");
                }
                else
                {
                    contextpers.Inteligence -= contextpers.Weapon.Inteligence;
                    contextpers.Dextenity -= contextpers.Weapon.Dexterity;
                    contextpers.Strenght -= contextpers.Weapon.Strength;
                    contextpers.Vitality -= contextpers.Weapon.Vitality;
                    contextpers.Health -= contextpers.Weapon.Health;
                    contextpers.Mana -= contextpers.Weapon.Mana;
                    contextpers.P_damage -= contextpers.Weapon.P_damage;
                    contextpers.Armor -= contextpers.Weapon.Armor;
                    contextpers.M_damage -= contextpers.Weapon.M_damage;
                    contextpers.M_defense -= contextpers.Weapon.M_defense;
                    contextpers.Crt_chanse /= contextpers.Weapon.Crt_chanse;
                    contextpers.Crt_damage /= contextpers.Weapon.Crt_damage;
                    contextpers.ShieldAvailable = true;
                    contextpers.Weapon = null;
                    Axe weapon = new Axe("Common");
                    contextpers.Weapon = weapon;
                    contextpers.Inteligence += weapon.Inteligence;
                    contextpers.Dextenity += weapon.Dexterity;
                    contextpers.Strenght += weapon.Strength;
                    contextpers.Vitality += weapon.Vitality;
                    contextpers.Health += weapon.Health;
                    contextpers.Mana += weapon.Mana;
                    contextpers.P_damage += weapon.P_damage;
                    contextpers.Armor += weapon.Armor;
                    contextpers.M_damage += weapon.M_damage;
                    contextpers.M_defense += weapon.M_defense;
                    contextpers.Crt_chanse *= weapon.Crt_chanse;
                    contextpers.Crt_damage *= weapon.Crt_damage;
                    contextpers.ShieldAvailable = weapon.ShieldAvailable;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    DataContext = contextpers;

                }


            }
            if (contextpers.BaseName == "Rogue")
            {
                var persesRogue = MongoDBConnection.GetRogue("Rogue");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                NavigationService.Navigate(new InfoHeroRogue(persRogue));
            }
            if (contextpers.BaseName == "Wizard")
            {
                var persesRogue = MongoDBConnection.GetWizard("Wizard");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                NavigationService.Navigate(new InfoWizardPage(persRogue));
            }
            if (contextpers.BaseName == "Warrior")
            {
                var persesRogue = MongoDBConnection.GetWarrior("Warrior");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                NavigationService.Navigate(new InfoWarriorPage(persRogue));
            }
        }

        private void MagicAxeBT_Click(object sender, RoutedEventArgs e)
        {
            if (contextpers.Level <= 10)
            {
                MessageBox.Show("К сожалению, ваш уровень не подходит для данного оружия");
            }
            else
            {
                if (contextpers.Weapon == null)
                {
                    Axe weapon = new Axe("Enchanted");
                    contextpers.Weapon = weapon;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    contextpers.Inteligence += weapon.Inteligence;
                    contextpers.Dextenity += weapon.Dexterity;
                    contextpers.Strenght += weapon.Strength;
                    contextpers.Vitality += weapon.Vitality;
                    contextpers.Health += weapon.Health;
                    contextpers.Mana += weapon.Mana;
                    contextpers.P_damage += weapon.P_damage;
                    contextpers.Armor += weapon.Armor;
                    contextpers.M_damage += weapon.M_damage;
                    contextpers.M_defense += weapon.M_defense;
                    contextpers.Crt_chanse *= weapon.Crt_chanse;
                    contextpers.Crt_damage *= weapon.Crt_damage;
                    contextpers.ShieldAvailable = weapon.ShieldAvailable;
                    DataContext = contextpers;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                }
                else
                {
                    if (contextpers.Weapon.Name == "Enchanted Axe")
                    {
                        MessageBox.Show("Оружие уже выбрано");
                    }
                    else
                    {
                        contextpers.Inteligence -= contextpers.Weapon.Inteligence;
                        contextpers.Dextenity -= contextpers.Weapon.Dexterity;
                        contextpers.Strenght -= contextpers.Weapon.Strength;
                        contextpers.Vitality -= contextpers.Weapon.Vitality;
                        contextpers.Health -= contextpers.Weapon.Health;
                        contextpers.Mana -= contextpers.Weapon.Mana;
                        contextpers.P_damage -= contextpers.Weapon.P_damage;
                        contextpers.Armor -= contextpers.Weapon.Armor;
                        contextpers.M_damage -= contextpers.Weapon.M_damage;
                        contextpers.M_defense -= contextpers.Weapon.M_defense;
                        contextpers.Crt_chanse /= contextpers.Weapon.Crt_chanse;
                        contextpers.Crt_damage /= contextpers.Weapon.Crt_damage;
                        contextpers.ShieldAvailable = true;
                        contextpers.Weapon = null;
                        Axe weapon = new Axe("Enchanted");
                        contextpers.Weapon = weapon;
                        contextpers.Inteligence += weapon.Inteligence;
                        contextpers.Dextenity += weapon.Dexterity;
                        contextpers.Strenght += weapon.Strength;
                        contextpers.Vitality += weapon.Vitality;
                        contextpers.Health += weapon.Health;
                        contextpers.Mana += weapon.Mana;
                        contextpers.P_damage += weapon.P_damage;
                        contextpers.Armor += weapon.Armor;
                        contextpers.M_damage += weapon.M_damage;
                        contextpers.M_defense += weapon.M_defense;
                        contextpers.Crt_chanse *= weapon.Crt_chanse;
                        contextpers.Crt_damage *= weapon.Crt_damage;
                        contextpers.ShieldAvailable = weapon.ShieldAvailable;
                        MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                        DataContext = contextpers;

                    }
                    

                }
                if (contextpers.BaseName == "Rogue")
                {
                    var persesRogue = MongoDBConnection.GetRogue("Rogue");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoHeroRogue(persRogue));
                }
                if (contextpers.BaseName == "Wizard")
                {
                    var persesRogue = MongoDBConnection.GetWizard("Wizard");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoWizardPage(persRogue));
                }
                if (contextpers.BaseName == "Warrior")
                {
                    var persesRogue = MongoDBConnection.GetWarrior("Warrior");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoWarriorPage(persRogue));
                }

            }
        }

        private void RareAxeBT_Click(object sender, RoutedEventArgs e)
        {
            if (contextpers.Level <= 30)
            {
                MessageBox.Show("К сожалению, ваш уровень не подходит для данного оружия");
            }
            else
            {
                if (contextpers.Weapon == null)
                {
                    Axe weapon = new Axe("Rare");
                    contextpers.Weapon = weapon;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    contextpers.Inteligence += weapon.Inteligence;
                    contextpers.Dextenity += weapon.Dexterity;
                    contextpers.Strenght += weapon.Strength;
                    contextpers.Vitality += weapon.Vitality;
                    contextpers.Health += weapon.Health;
                    contextpers.Mana += weapon.Mana;
                    contextpers.P_damage += weapon.P_damage;
                    contextpers.Armor += weapon.Armor;
                    contextpers.M_damage += weapon.M_damage;
                    contextpers.M_defense += weapon.M_defense;
                    contextpers.Crt_chanse *= weapon.Crt_chanse;
                    contextpers.Crt_damage *= weapon.Crt_damage;
                    contextpers.ShieldAvailable = weapon.ShieldAvailable;
                    DataContext = contextpers;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoHeroRogue(persRogue));

                }
                else
                {
                    if (contextpers.Weapon.Name == "Rare Axe")
                    {
                        MessageBox.Show("Оружие уже выбрано");
                    }
                    else
                    {
                        contextpers.Inteligence -= contextpers.Weapon.Inteligence;
                        contextpers.Dextenity -= contextpers.Weapon.Dexterity;
                        contextpers.Strenght -= contextpers.Weapon.Strength;
                        contextpers.Vitality -= contextpers.Weapon.Vitality;
                        contextpers.Health -= contextpers.Weapon.Health;
                        contextpers.Mana -= contextpers.Weapon.Mana;
                        contextpers.P_damage -= contextpers.Weapon.P_damage;
                        contextpers.Armor -= contextpers.Weapon.Armor;
                        contextpers.M_damage -= contextpers.Weapon.M_damage;
                        contextpers.M_defense -= contextpers.Weapon.M_defense;
                        contextpers.Crt_chanse /= contextpers.Weapon.Crt_chanse;
                        contextpers.Crt_damage /= contextpers.Weapon.Crt_damage;
                        contextpers.ShieldAvailable = true;
                        contextpers.Weapon = null;
                        Axe weapon = new Axe("Rare");
                        contextpers.Weapon = weapon;
                        contextpers.Inteligence += weapon.Inteligence;
                        contextpers.Dextenity += weapon.Dexterity;
                        contextpers.Strenght += weapon.Strength;
                        contextpers.Vitality += weapon.Vitality;
                        contextpers.Health += weapon.Health;
                        contextpers.Mana += weapon.Mana;
                        contextpers.P_damage += weapon.P_damage;
                        contextpers.Armor += weapon.Armor;
                        contextpers.M_damage += weapon.M_damage;
                        contextpers.M_defense += weapon.M_defense;
                        contextpers.Crt_chanse *= weapon.Crt_chanse;
                        contextpers.Crt_damage *= weapon.Crt_damage;
                        contextpers.ShieldAvailable = weapon.ShieldAvailable;
                        MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                        DataContext = contextpers;

                    }
                }
                if (contextpers.BaseName == "Rogue")
                {
                    var persesRogue = MongoDBConnection.GetRogue("Rogue");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoHeroRogue(persRogue));
                }
                if (contextpers.BaseName == "Wizard")
                {
                    var persesRogue = MongoDBConnection.GetWizard("Wizard");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoWizardPage(persRogue));
                }
                if (contextpers.BaseName == "Warrior")
                {
                    var persesRogue = MongoDBConnection.GetWarrior("Warrior");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoWarriorPage(persRogue));
                }
            }
        }

        private void HammerBT_Click(object sender, RoutedEventArgs e)
        {
            if (contextpers.Weapon == null)
            {
                Hammer weapon = new Hammer("Common");
                contextpers.Weapon = weapon;
                MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                contextpers.Inteligence += weapon.Inteligence;
                contextpers.Dextenity += weapon.Dexterity;
                contextpers.Strenght += weapon.Strength;
                contextpers.Vitality += weapon.Vitality;
                contextpers.Health += weapon.Health;
                contextpers.Mana += weapon.Mana;
                contextpers.P_damage += weapon.P_damage;
                contextpers.Armor += weapon.Armor;
                contextpers.M_damage += weapon.M_damage;
                contextpers.M_defense += weapon.M_defense;
                contextpers.Crt_chanse *= weapon.Crt_chanse;
                contextpers.Crt_damage *= weapon.Crt_damage;
                contextpers.ShieldAvailable = weapon.ShieldAvailable;
                DataContext = contextpers;
                MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
            }
            else
            {
                if (contextpers.Weapon.Name == "Hammer")
                {
                    MessageBox.Show("Оружие уже выбрано");
                }
                else
                {
                    contextpers.Inteligence -= contextpers.Weapon.Inteligence;
                    contextpers.Dextenity -= contextpers.Weapon.Dexterity;
                    contextpers.Strenght -= contextpers.Weapon.Strength;
                    contextpers.Vitality -= contextpers.Weapon.Vitality;
                    contextpers.Health -= contextpers.Weapon.Health;
                    contextpers.Mana -= contextpers.Weapon.Mana;
                    contextpers.P_damage -= contextpers.Weapon.P_damage;
                    contextpers.Armor -= contextpers.Weapon.Armor;
                    contextpers.M_damage -= contextpers.Weapon.M_damage;
                    contextpers.M_defense -= contextpers.Weapon.M_defense;
                    contextpers.Crt_chanse /= contextpers.Weapon.Crt_chanse;
                    contextpers.Crt_damage /= contextpers.Weapon.Crt_damage;
                    contextpers.ShieldAvailable = true;
                    contextpers.Weapon = null;
                    Hammer weapon = new Hammer("Common");
                    contextpers.Weapon = weapon;
                    contextpers.Inteligence += weapon.Inteligence;
                    contextpers.Dextenity += weapon.Dexterity;
                    contextpers.Strenght += weapon.Strength;
                    contextpers.Vitality += weapon.Vitality;
                    contextpers.Health += weapon.Health;
                    contextpers.Mana += weapon.Mana;
                    contextpers.P_damage += weapon.P_damage;
                    contextpers.Armor += weapon.Armor;
                    contextpers.M_damage += weapon.M_damage;
                    contextpers.M_defense += weapon.M_defense;
                    contextpers.Crt_chanse *= weapon.Crt_chanse;
                    contextpers.Crt_damage *= weapon.Crt_damage;
                    contextpers.ShieldAvailable = weapon.ShieldAvailable;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    DataContext = contextpers;

                }


            }
            if (contextpers.BaseName == "Rogue")
            {
                var persesRogue = MongoDBConnection.GetRogue("Rogue");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                NavigationService.Navigate(new InfoHeroRogue(persRogue));
            }
            if (contextpers.BaseName == "Wizard")
            {
                var persesRogue = MongoDBConnection.GetWizard("Wizard");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                NavigationService.Navigate(new InfoWizardPage(persRogue));
            }
            if (contextpers.BaseName == "Warrior")
            {
                var persesRogue = MongoDBConnection.GetWarrior("Warrior");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                NavigationService.Navigate(new InfoWarriorPage(persRogue));
            }
        }

        private void MagicHammerBT_Click(object sender, RoutedEventArgs e)
        {
            if (contextpers.Level <= 10)
            {
                MessageBox.Show("К сожалению, ваш уровень не подходит для данного оружия");
            }
            else
            {
                if (contextpers.Weapon == null)
                {
                    Hammer weapon = new Hammer("Enchanted");
                    contextpers.Weapon = weapon;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    contextpers.Inteligence += weapon.Inteligence;
                    contextpers.Dextenity += weapon.Dexterity;
                    contextpers.Strenght += weapon.Strength;
                    contextpers.Vitality += weapon.Vitality;
                    contextpers.Health += weapon.Health;
                    contextpers.Mana += weapon.Mana;
                    contextpers.P_damage += weapon.P_damage;
                    contextpers.Armor += weapon.Armor;
                    contextpers.M_damage += weapon.M_damage;
                    contextpers.M_defense += weapon.M_defense;
                    contextpers.Crt_chanse *= weapon.Crt_chanse;
                    contextpers.Crt_damage *= weapon.Crt_damage;
                    contextpers.ShieldAvailable = weapon.ShieldAvailable;
                    DataContext = contextpers;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoHeroRogue(persRogue));

                }
                else
                {
                    if (contextpers.Weapon.Name == "Enchanted Hammer")
                    {
                        MessageBox.Show("Оружие уже выбрано");
                    }
                    else
                    {
                        contextpers.Inteligence -= contextpers.Weapon.Inteligence;
                        contextpers.Dextenity -= contextpers.Weapon.Dexterity;
                        contextpers.Strenght -= contextpers.Weapon.Strength;
                        contextpers.Vitality -= contextpers.Weapon.Vitality;
                        contextpers.Health -= contextpers.Weapon.Health;
                        contextpers.Mana -= contextpers.Weapon.Mana;
                        contextpers.P_damage -= contextpers.Weapon.P_damage;
                        contextpers.Armor -= contextpers.Weapon.Armor;
                        contextpers.M_damage -= contextpers.Weapon.M_damage;
                        contextpers.M_defense -= contextpers.Weapon.M_defense;
                        contextpers.Crt_chanse /= contextpers.Weapon.Crt_chanse;
                        contextpers.Crt_damage /= contextpers.Weapon.Crt_damage;
                        contextpers.ShieldAvailable = true;
                        contextpers.Weapon = null;
                        Hammer weapon = new Hammer("Enchanted");
                        contextpers.Weapon = weapon;
                        contextpers.Inteligence += weapon.Inteligence;
                        contextpers.Dextenity += weapon.Dexterity;
                        contextpers.Strenght += weapon.Strength;
                        contextpers.Vitality += weapon.Vitality;
                        contextpers.Health += weapon.Health;
                        contextpers.Mana += weapon.Mana;
                        contextpers.P_damage += weapon.P_damage;
                        contextpers.Armor += weapon.Armor;
                        contextpers.M_damage += weapon.M_damage;
                        contextpers.M_defense += weapon.M_defense;
                        contextpers.Crt_chanse *= weapon.Crt_chanse;
                        contextpers.Crt_damage *= weapon.Crt_damage;
                        contextpers.ShieldAvailable = weapon.ShieldAvailable;
                        MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                        DataContext = contextpers;

                    }
                }
                if (contextpers.BaseName == "Rogue")
                {
                    var persesRogue = MongoDBConnection.GetRogue("Rogue");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoHeroRogue(persRogue));
                }
                if (contextpers.BaseName == "Wizard")
                {
                    var persesRogue = MongoDBConnection.GetWizard("Wizard");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoWizardPage(persRogue));
                }
                if (contextpers.BaseName == "Warrior")
                {
                    var persesRogue = MongoDBConnection.GetWarrior("Warrior");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoWarriorPage(persRogue));
                }
            }
        }

        private void RareHammerBT_Click(object sender, RoutedEventArgs e)
        {
            if (contextpers.Level <= 30)
            {
                MessageBox.Show("К сожалению, ваш уровень не подходит для данного оружия");
            }
            else
            {
                if (contextpers.Weapon == null)
                {
                    Hammer weapon = new Hammer("Rare");
                    contextpers.Weapon = weapon;
                    contextpers.Inteligence += weapon.Inteligence;
                    contextpers.Dextenity += weapon.Dexterity;
                    contextpers.Strenght += weapon.Strength;
                    contextpers.Vitality += weapon.Vitality;
                    contextpers.Health += weapon.Health;
                    contextpers.Mana += weapon.Mana;
                    contextpers.P_damage += weapon.P_damage;
                    contextpers.Armor += weapon.Armor;
                    contextpers.M_damage += weapon.M_damage;
                    contextpers.M_defense += weapon.M_defense;
                    contextpers.Crt_chanse *= weapon.Crt_chanse;
                    contextpers.Crt_damage *= weapon.Crt_damage;
                    contextpers.ShieldAvailable = weapon.ShieldAvailable;
                    DataContext = contextpers;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoHeroRogue(persRogue));

                }
                else
                {
                    if (contextpers.Weapon.Name == "Rare Hammer")
                    {
                        MessageBox.Show("Оружие уже выбрано");
                    }
                    else
                    {
                        contextpers.Inteligence -= contextpers.Weapon.Inteligence;
                        contextpers.Dextenity -= contextpers.Weapon.Dexterity;
                        contextpers.Strenght -= contextpers.Weapon.Strength;
                        contextpers.Vitality -= contextpers.Weapon.Vitality;
                        contextpers.Health -= contextpers.Weapon.Health;
                        contextpers.Mana -= contextpers.Weapon.Mana;
                        contextpers.P_damage -= contextpers.Weapon.P_damage;
                        contextpers.Armor -= contextpers.Weapon.Armor;
                        contextpers.M_damage -= contextpers.Weapon.M_damage;
                        contextpers.M_defense -= contextpers.Weapon.M_defense;
                        contextpers.Crt_chanse /= contextpers.Weapon.Crt_chanse;
                        contextpers.Crt_damage /= contextpers.Weapon.Crt_damage;
                        contextpers.ShieldAvailable = true;
                        contextpers.Weapon = null;
                        Hammer weapon = new Hammer("Rare");
                        contextpers.Weapon = weapon;
                        contextpers.Inteligence += weapon.Inteligence;
                        contextpers.Dextenity += weapon.Dexterity;
                        contextpers.Strenght += weapon.Strength;
                        contextpers.Vitality += weapon.Vitality;
                        contextpers.Health += weapon.Health;
                        contextpers.Mana += weapon.Mana;
                        contextpers.P_damage += weapon.P_damage;
                        contextpers.Armor += weapon.Armor;
                        contextpers.M_damage += weapon.M_damage;
                        contextpers.M_defense += weapon.M_defense;
                        contextpers.Crt_chanse *= weapon.Crt_chanse;
                        contextpers.Crt_damage *= weapon.Crt_damage;
                        contextpers.ShieldAvailable = weapon.ShieldAvailable;
                        MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                        DataContext = contextpers;

                    }
                }
                if (contextpers.BaseName == "Rogue")
                {
                    var persesRogue = MongoDBConnection.GetRogue("Rogue");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoHeroRogue(persRogue));
                }
                if (contextpers.BaseName == "Wizard")
                {
                    var persesRogue = MongoDBConnection.GetWizard("Wizard");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoWizardPage(persRogue));
                }
                if (contextpers.BaseName == "Warrior")
                {
                    var persesRogue = MongoDBConnection.GetWarrior("Warrior");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoWarriorPage(persRogue));
                }
            }
        }

        private void StaffBT_Click(object sender, RoutedEventArgs e)
        {
            if (contextpers.Weapon == null)
            {
                Staff weapon = new Staff("Common");
                contextpers.Weapon = weapon;
                MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                contextpers.Inteligence += weapon.Inteligence;
                contextpers.Dextenity += weapon.Dexterity;
                contextpers.Strenght += weapon.Strength;
                contextpers.Vitality += weapon.Vitality;
                contextpers.Health += weapon.Health;
                contextpers.Mana += weapon.Mana;
                contextpers.P_damage += weapon.P_damage;
                contextpers.Armor += weapon.Armor;
                contextpers.M_damage += weapon.M_damage;
                contextpers.M_defense += weapon.M_defense;
                contextpers.Crt_chanse *= weapon.Crt_chanse;
                contextpers.Crt_damage *= weapon.Crt_damage;
                contextpers.ShieldAvailable = weapon.ShieldAvailable;
                DataContext = contextpers;
                MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
            }
            else
            {
                if (contextpers.Weapon.Name == "Staff")
                {
                    MessageBox.Show("Оружие уже выбрано");
                }
                else
                {
                    contextpers.Inteligence -= contextpers.Weapon.Inteligence;
                    contextpers.Dextenity -= contextpers.Weapon.Dexterity;
                    contextpers.Strenght -= contextpers.Weapon.Strength;
                    contextpers.Vitality -= contextpers.Weapon.Vitality;
                    contextpers.Health -= contextpers.Weapon.Health;
                    contextpers.Mana -= contextpers.Weapon.Mana;
                    contextpers.P_damage -= contextpers.Weapon.P_damage;
                    contextpers.Armor -= contextpers.Weapon.Armor;
                    contextpers.M_damage -= contextpers.Weapon.M_damage;
                    contextpers.M_defense -= contextpers.Weapon.M_defense;
                    contextpers.Crt_chanse /= contextpers.Weapon.Crt_chanse;
                    contextpers.Crt_damage /= contextpers.Weapon.Crt_damage;
                    contextpers.ShieldAvailable = true;
                    contextpers.Weapon = null;
                    Staff weapon = new Staff("Common");
                    contextpers.Weapon = weapon;
                    contextpers.Inteligence += weapon.Inteligence;
                    contextpers.Dextenity += weapon.Dexterity;
                    contextpers.Strenght += weapon.Strength;
                    contextpers.Vitality += weapon.Vitality;
                    contextpers.Health += weapon.Health;
                    contextpers.Mana += weapon.Mana;
                    contextpers.P_damage += weapon.P_damage;
                    contextpers.Armor += weapon.Armor;
                    contextpers.M_damage += weapon.M_damage;
                    contextpers.M_defense += weapon.M_defense;
                    contextpers.Crt_chanse *= weapon.Crt_chanse;
                    contextpers.Crt_damage *= weapon.Crt_damage;
                    contextpers.ShieldAvailable = weapon.ShieldAvailable;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    DataContext = contextpers;

                }


            }
            if (contextpers.BaseName == "Rogue")
            {
                var persesRogue = MongoDBConnection.GetRogue("Rogue");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                NavigationService.Navigate(new InfoHeroRogue(persRogue));
            }
            if (contextpers.BaseName == "Wizard")
            {
                var persesRogue = MongoDBConnection.GetWizard("Wizard");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                NavigationService.Navigate(new InfoWizardPage(persRogue));
            }
            if (contextpers.BaseName == "Warrior")
            {
                var persesRogue = MongoDBConnection.GetWarrior("Warrior");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                NavigationService.Navigate(new InfoWarriorPage(persRogue));
            }
        }

        private void MagicStaffBT_Click(object sender, RoutedEventArgs e)
        {
            if (contextpers.Level <= 10)
            {
                MessageBox.Show("К сожалению, ваш уровень не подходит для данного оружия");
            }
            else
            {
                if (contextpers.Weapon == null)
                {
                    Staff weapon = new Staff("Enchanted");
                    contextpers.Weapon = weapon;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    contextpers.Inteligence += weapon.Inteligence;
                    contextpers.Dextenity += weapon.Dexterity;
                    contextpers.Strenght += weapon.Strength;
                    contextpers.Vitality += weapon.Vitality;
                    contextpers.Health += weapon.Health;
                    contextpers.Mana += weapon.Mana;
                    contextpers.P_damage += weapon.P_damage;
                    contextpers.Armor += weapon.Armor;
                    contextpers.M_damage += weapon.M_damage;
                    contextpers.M_defense += weapon.M_defense;
                    contextpers.Crt_chanse *= weapon.Crt_chanse;
                    contextpers.Crt_damage *= weapon.Crt_damage;
                    contextpers.ShieldAvailable = weapon.ShieldAvailable;
                    DataContext = contextpers;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoHeroRogue(persRogue));

                }
                else
                {
                    if (contextpers.Weapon.Name == "Enchanted Staff")
                    {
                        MessageBox.Show("Оружие уже выбрано");
                    }
                    else
                    {
                        contextpers.Inteligence -= contextpers.Weapon.Inteligence;
                        contextpers.Dextenity -= contextpers.Weapon.Dexterity;
                        contextpers.Strenght -= contextpers.Weapon.Strength;
                        contextpers.Vitality -= contextpers.Weapon.Vitality;
                        contextpers.Health -= contextpers.Weapon.Health;
                        contextpers.Mana -= contextpers.Weapon.Mana;
                        contextpers.P_damage -= contextpers.Weapon.P_damage;
                        contextpers.Armor -= contextpers.Weapon.Armor;
                        contextpers.M_damage -= contextpers.Weapon.M_damage;
                        contextpers.M_defense -= contextpers.Weapon.M_defense;
                        contextpers.Crt_chanse /= contextpers.Weapon.Crt_chanse;
                        contextpers.Crt_damage /= contextpers.Weapon.Crt_damage;
                        contextpers.ShieldAvailable = true;
                        contextpers.Weapon = null;
                        Staff weapon = new Staff("Enchanted");
                        contextpers.Weapon = weapon;
                        contextpers.Inteligence += weapon.Inteligence;
                        contextpers.Dextenity += weapon.Dexterity;
                        contextpers.Strenght += weapon.Strength;
                        contextpers.Vitality += weapon.Vitality;
                        contextpers.Health += weapon.Health;
                        contextpers.Mana += weapon.Mana;
                        contextpers.P_damage += weapon.P_damage;
                        contextpers.Armor += weapon.Armor;
                        contextpers.M_damage += weapon.M_damage;
                        contextpers.M_defense += weapon.M_defense;
                        contextpers.Crt_chanse *= weapon.Crt_chanse;
                        contextpers.Crt_damage *= weapon.Crt_damage;
                        contextpers.ShieldAvailable = weapon.ShieldAvailable;
                        MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                        DataContext = contextpers;

                    }
                }
                if (contextpers.BaseName == "Rogue")
                {
                    var persesRogue = MongoDBConnection.GetRogue("Rogue");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoHeroRogue(persRogue));
                }
                if (contextpers.BaseName == "Wizard")
                {
                    var persesRogue = MongoDBConnection.GetWizard("Wizard");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoWizardPage(persRogue));
                }
                if (contextpers.BaseName == "Warrior")
                {
                    var persesRogue = MongoDBConnection.GetWarrior("Warrior");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoWarriorPage(persRogue));
                }
            }
        }

        private void RareStaffBT_Click(object sender, RoutedEventArgs e)
        {
            if (contextpers.Level <= 30)
            {
                MessageBox.Show("К сожалению, ваш уровень не подходит для данного оружия");
            }
            else
            {
                if (contextpers.Weapon == null)
                {
                    Staff weapon = new Staff("Rare");
                    contextpers.Weapon = weapon;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    contextpers.Inteligence += weapon.Inteligence;
                    contextpers.Dextenity += weapon.Dexterity;
                    contextpers.Strenght += weapon.Strength;
                    contextpers.Vitality += weapon.Vitality;
                    contextpers.Health += weapon.Health;
                    contextpers.Mana += weapon.Mana;
                    contextpers.P_damage += weapon.P_damage;
                    contextpers.Armor += weapon.Armor;
                    contextpers.M_damage += weapon.M_damage;
                    contextpers.M_defense += weapon.M_defense;
                    contextpers.Crt_chanse *= weapon.Crt_chanse;
                    contextpers.Crt_damage *= weapon.Crt_damage;
                    contextpers.ShieldAvailable = weapon.ShieldAvailable;
                    DataContext = contextpers;
                    MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                    var persesRogue = MongoDBConnection.Get<Rogue>("Rgb_Game", "CharacterCollection");
                    var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                    NavigationService.Navigate(new InfoHeroRogue(persRogue));

                }
                else
                {
                    if (contextpers.Weapon.Name == "Rare Staff")
                    {
                        MessageBox.Show("Оружие уже выбрано");
                    }
                    else
                    {
                        contextpers.Inteligence -= contextpers.Weapon.Inteligence;
                        contextpers.Dextenity -= contextpers.Weapon.Dexterity;
                        contextpers.Strenght -= contextpers.Weapon.Strength;
                        contextpers.Vitality -= contextpers.Weapon.Vitality;
                        contextpers.Health -= contextpers.Weapon.Health;
                        contextpers.Mana -= contextpers.Weapon.Mana;
                        contextpers.P_damage -= contextpers.Weapon.P_damage;
                        contextpers.Armor -= contextpers.Weapon.Armor;
                        contextpers.M_damage -= contextpers.Weapon.M_damage;
                        contextpers.M_defense -= contextpers.Weapon.M_defense;
                        contextpers.Crt_chanse /= contextpers.Weapon.Crt_chanse;
                        contextpers.Crt_damage /= contextpers.Weapon.Crt_damage;
                        contextpers.ShieldAvailable = true;
                        contextpers.Weapon = null;
                        Staff weapon = new Staff("Rare");
                        contextpers.Weapon = weapon;
                        contextpers.Inteligence += weapon.Inteligence;
                        contextpers.Dextenity += weapon.Dexterity;
                        contextpers.Strenght += weapon.Strength;
                        contextpers.Vitality += weapon.Vitality;
                        contextpers.Health += weapon.Health;
                        contextpers.Mana += weapon.Mana;
                        contextpers.P_damage += weapon.P_damage;
                        contextpers.Armor += weapon.Armor;
                        contextpers.M_damage += weapon.M_damage;
                        contextpers.M_defense += weapon.M_defense;
                        contextpers.Crt_chanse *= weapon.Crt_chanse;
                        contextpers.Crt_damage *= weapon.Crt_damage;
                        contextpers.ShieldAvailable = weapon.ShieldAvailable;
                        MongoDBConnection.Put("Rgb_Game", "CharacterCollection", contextpers._id, contextpers);
                        DataContext = contextpers;

                    }

                }
            }
            if (contextpers.BaseName == "Rogue")
            {
                var persesRogue = MongoDBConnection.GetRogue("Rogue");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                NavigationService.Navigate(new InfoHeroRogue(persRogue));
            }
            if (contextpers.BaseName == "Wizard")
            {
                var persesRogue = MongoDBConnection.GetWizard("Wizard");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                NavigationService.Navigate(new InfoWizardPage(persRogue));
            }
            if (contextpers.BaseName == "Warrior")
            {
                var persesRogue = MongoDBConnection.GetWarrior("Warrior");
                var persRogue = persesRogue.FirstOrDefault(x => x.Name == NameTB.Text);
                NavigationService.Navigate(new InfoWarriorPage(persRogue));
            }
        }
    }
}
