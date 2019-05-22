using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAdventure
{
    class Location
    {
        protected string _welcomeString;

        public string welcomeString
        {
            get { return _welcomeString; }
            set { _welcomeString = value; }
        }

        public virtual void welcome()
        {
            Console.WriteLine(welcomeString);
            Console.ReadLine();
        }

        public virtual void mission()
        {

        }

    }
}
