using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAdventure
{
    class Player
    {
        protected string _name;
        protected string _className;
        protected int _health = 100;
        protected int _baseDamage;
        
        public string classname
        {
            get { return _className; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int health
        {
            get { return _health; }
            set
            {
                if(_health <= 0)
                {
                    //do dieing stuff
                }
                else
                {
                    _health = value;
                }
            }
        }

        public int baseDamage
        {
            get { return _baseDamage; }
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Base damage cannot be a negative");
                }
                else
                {
                    _baseDamage = value;
                }
            }
        }

        public virtual int DealDamage()
        {
            return 0;
        }

    }
}
