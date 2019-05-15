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

        //public virtual void
    }
}
