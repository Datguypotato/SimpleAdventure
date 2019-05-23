using System;
using SimpleAdventure.PlayerClasses;
using SimpleAdventure.Enemies;
using SimpleAdventure.Locations;
using SimpleAdventure.Items;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            {
/* Welkom bij Simple Adventure
 * Hier zie je een raamwerk van een text based rpg
 * De classes en subclasses zijn al aangemaakt, subclasses staan in de mapjes
 * Aan jou de taak om hier een invulling aan te geven!
 * Wat moet je laten zien:
 *  - Dat je OOP beheerst
 *  - Dat je inheritance beheerst
 *  - Dat je in staat bent om output naar de console te krijgen op basis van de classes
 *  - Het hoeft geen volledig spel te zijn, maar het moet iets doen en het moet werken
 *  - En natuurlijk op de juiste manier in elkaar zitten
 * Waar scoor ik bonuspunten mee:
 *  - Gebruik polymorphism d.m.v. virtual methods en/of verschillende constructors (bijvoorbeeld subclasses)
 *  - Je hebt een speelbare game gemaakt
 *  - Je hebt zinvolle en werkende uitbreidingen gemaakt op het raamwerk
 * Kwaliteit gaat boven kwantiteit, ga pas uitbreiden als je basis goed is
 * Werk alleen: als ik bij twee personen dezelfde code zie, krijgen jullie allebei een onvoldoende
 * Gebruik comments ten overvloede! Leg uit wat je doet! Hoe de comments kort, duidelijk en volledig!
 */
            }

            Player player;

            Forest forest = new Forest();
            Swamp swamp = new Swamp();
            Plains plains = new Plains();
            
            Direwolf wolf = new Direwolf();
            Goblin goblin = new Goblin();
            Orc orc = new Orc();

            Chest chest = new Chest();
            Diamond dia = new Diamond();
            Key key = new Key();

            int userNumber;
            string tempName;

            //creating player
            #region playerSetup
            Console.WriteLine("Greeting new player");
            Console.WriteLine("Welcome to SimpelAdventure");
            Console.ReadLine();

            Console.WriteLine("What is your name?");
            tempName = Console.ReadLine();

            Console.WriteLine("Choose a class!");
            Console.WriteLine("1. Babarian: You like hitting people with sharp stuff || 2. Sorcerer: You like hitting stuff but with lighting");
            userNumber = makeDecision(2);
            
            
            if(userNumber == 1)
            {
                player = new Barbarian(tempName);
            }
            else
            {
                player = new Sorcerer(tempName);
            }

            Console.Clear();

            Console.WriteLine("Your name is " + player.name);
            Console.WriteLine("You Choose class " + player.classname);

            Console.ReadLine();
            Console.Clear();
            #endregion

            Console.Clear();
            do
            {
                //end the game if you find both key and chest
                if (key.hasItem && chest.hasItem)
                {
                    dia.hasItem = true;
                    Console.WriteLine("You use the key on the chest and you find a diamond!");
                    Console.WriteLine("This mean you won the game for some reason");
                    Console.WriteLine("Thanks for playing the game");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Choose where you want to go");
                    Console.WriteLine("1. Church: For your healling needs 2. Forest: Lots of murder puppies\n3. Plains: Boring place nothing special 4. Swamp: What are you doing here!");
                    userNumber = makeDecision(4);

                    switch (userNumber)
                    {
                        case 1:
                            EnterChurch(player);
                            break;
                        case 2:
                            EnterLoc(forest, wolf);
                            break;
                        case 3:
                            EnterLoc(plains, goblin);
                            break;
                        case 4:
                            EnterLoc(swamp, orc);
                            break;
                        default:
                            Console.WriteLine("Something went very wrong");
                            break;

                    }
                }


            } while (!dia.hasItem);

            int makeDecision(int maxNumber)
            {
                //This is for whevenever the player has to make a decision
                string userInput;

                do
                {
                    Console.WriteLine("Choose a number between 1 and " + maxNumber);
                    userInput = Console.ReadLine();
                    int.TryParse(userInput, out userNumber);

                } while (userNumber < 1 || userNumber > maxNumber);

                Console.Clear();
                return userNumber;
            }

            //turn based combat
            void Battle(Player p, Enemy e)
            {
                Console.WriteLine("You are fighting a " + e.name);
                Console.WriteLine("It has " + e.str);
                do
                {
                    
                    p.health -= e.DealDamage();
                    Console.WriteLine(p.name + " has " + p.health + " hp left");
                    e.health -= p.DealDamage();
                    Console.WriteLine(e.name + " has " + e.health + " hp left");
                    Console.ReadLine();

                } while (p.health > 0 && e.health > 0);

                e.ResetHealth();

                //Earn item
                if(e.name == "Direwolf" || e.name == "Goblin")
                {
                    FindItem(key);

                }
                else if (e.name == "Orc" || e.name == "Goblin")
                {
                    FindItem(chest);
                }

                Console.ReadLine();
                Console.Clear();
            }

            //works on everytinh execpt church
            void EnterLoc(Location loc, Enemy e)
            {
                loc.welcome();

                do
                {
                    loc.options();
                    userNumber = makeDecision(2);

                    if (userNumber == 1)
                    {
                        Battle(player, e);
                    }
                    else
                    {
                        loc.Leave();
                    }

                } while (userNumber != 2);
            }

            void EnterChurch(Player p)
            {
                Church church = new Church();
                church.welcome();
                
                do
                {
                    church.options();
                    userNumber = makeDecision(2);

                    if (userNumber == 1)
                    {
                        Console.WriteLine("You are fully healed!");
                        church.FullHeal(p);
                    }
                    else
                    {
                        church.Leave();
                    }

                } while (userNumber != 2);
            }

            void FindItem(Item item)
            {
                Random rnd = new Random();
                int i = rnd.Next(2);

                if (i == 1)
                {
                    item.hasItem = true;
                    Console.WriteLine("You found " + item.itemName);
                }
                else
                {
                    Console.WriteLine("You found no loot");
                }
            }
        }
    }
}
