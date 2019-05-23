using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAdventure.Locations
{
    class Swamp : Location
    {
        public Swamp()
        {
            _welcomeString = "WHAT ARE YOU DOING IN MY SWAMP";
            _goodbye = "THANKS FOR LEAVING MY SWAMP";
        }
    }
}
