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

            _className = "Sorcerer";
            _baseDamage = 1;
        }


        public int DealDamage()
        {
            Random rnd = new Random();
            

            return _baseDamage * rnd.Next(1, 6) * rnd.Next(1, 6);
        }
    }
}
