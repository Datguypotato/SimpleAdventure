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
        protected int _strenght;

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

        public int str
        {
            get { return _strenght; }
        }

        public virtual int DealDamage()
        {
            return 0;
        }

    }
}
