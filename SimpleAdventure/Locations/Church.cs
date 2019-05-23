using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAdventure.Locations
{
    class Church : Location
    {

        public Church()
        {
            _welcomeString = "Greeting traveler, Welcome to the church we are very cool people and stuff";

            _goodbye = "Goodluck traveler";
        }

        public override void options()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Heal || 2. Leave");
        }

        public void FullHeal(Player p)
        {
            p.health = 100;
        }

    }
}
