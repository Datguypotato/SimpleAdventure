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
        protected string _goodbye;

        //public string welcomeString
        //{
        //    get { return _welcomeString; }
        //    set { _welcomeString = value; }
        //}

        //public string farewellString
        //{
        //    get { return _FarewellString; }
        //    set { _FarewellString = value; }
        //}

        public void welcome()
        {
            Console.WriteLine(_welcomeString);
            Console.ReadLine();
        }

        public virtual void options()
        {
            Console.WriteLine("what do you want to do?");
            Console.WriteLine("1. Find enemy || 2. leave");
        }

        public virtual void Leave()
        {
            Console.WriteLine(_goodbye);
            Console.ReadLine();
        }

    }
}
