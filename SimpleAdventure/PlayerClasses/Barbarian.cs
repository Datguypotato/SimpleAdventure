using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAdventure.PlayerClasses
{
    class Barbarian : Player
    {

        public Barbarian(string n)
        {
            if(n != "")
            {
                this._name = n;
            }
            else
            {
                this._name = "Hero";
            }

            _className = "Barbarian";
            _baseDamage = 10;
        }

        public int DealDamage()
        {
            Random rnd = new Random();


            return _baseDamage * rnd.Next(10);
        }
    }
}
