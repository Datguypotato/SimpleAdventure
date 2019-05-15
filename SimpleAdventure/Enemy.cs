using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAdventure
{
    class Enemy
    {
        protected string _name;
        protected int _health;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int health
        {
            get { return _health; }
            set { _health = value; }
        }
    }
}
