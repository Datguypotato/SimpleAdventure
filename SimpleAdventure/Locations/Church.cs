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
            welcomeString = "Greeting traveler, Welcome to the church we are very cool people and stuff";
        }

        public override void welcome()
        {
            base.welcome();
        }

        public void FullHeal(Player p)
        {
            p.health = 100;
        }
    }
}
