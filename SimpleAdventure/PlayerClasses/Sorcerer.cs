using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAdventure.PlayerClasses
{
    class Sorcerer : Player
    {

        public Sorcerer(string n)
        {
            if (n != null)
            {
                this._name = n;
            }
            else
            {
                this._name = "Hero";
            }

            _className = "Barbarian";
        }
    }
}
