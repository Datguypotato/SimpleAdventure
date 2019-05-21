using System;
using SimpleAdventure.PlayerClasses;
using SimpleAdventure.Enemies;
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
            Enemy wolf = new Direwolf();
            
            

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

            //Battle(player);

            //Console.WriteLine("Choose where you want to go");
            //Console.WriteLine("1. Church: For your healling needs 2. Forest: Lots of murder puppies\n3. Plains: Boring place nothing special 4. Swamp: What are you doing here!");
            //makeDecision(3);

            //Console.WriteLine("You typed: " + userNumber);
            //Console.ReadLine();

            Battle(player, wolf);

            int makeDecision(int maxNumber)
            {
                //This is for whevenever the player has to make a decision
                string userInput;

                do
                {
                    Console.WriteLine("Choose a number between 1 and " + maxNumber);
                    userInput = Console.ReadLine();
                    int.TryParse(userInput, out userNumber);
                    //Console.WriteLine(userNumber);

                } while (userNumber < 1 || userNumber > maxNumber);

                return userNumber;
            }

            void Battle(Player p, Enemy e)
            {
                do
                {
                    Console.WriteLine("IM A ALIVE");
                    p.health -= e.DealDamage();
                    Console.WriteLine(p.name + " has " + p.health + " hp left");
                    e.health -= p.DealDamage();
                    Console.WriteLine(e.name + " has " + e.health + " hp left");
                    Console.ReadLine();


                } while (p.health > 0 && e.health >
                
                
                
                0);
            }


            //void Battle(Player p)
            //{
            //    //this is for testing battles
            //    do
            //    {
            //        Console.WriteLine("IM A ALIVE");
            //        Console.WriteLine(p.health);
            //        player.health -= 10;
            //        Console.ReadLine();


            //    } while (p.health > 0);
            //}
        }
    }
}
