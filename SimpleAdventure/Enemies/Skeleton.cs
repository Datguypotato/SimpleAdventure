using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAdventure.Enemies
{
    class Skeleton : Enemy
    {
        public Skeleton()
        {
            _name = "Skeleton";
            _health = 200;
            _maxHealth = health;
            _strenght = 12;
        }
    }
}
