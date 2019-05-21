using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAdventure.Enemies
{
    class Direwolf : Enemy
    {
        public Direwolf()
        {
            _name = "Direwolf";
            _health = 50;
            _strenght = 1;
        }

        public override int DealDamage()
        {
            Random rnd = new Random();

            return _strenght * rnd.Next(6);
        }
    }
}
