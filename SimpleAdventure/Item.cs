using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAdventure
{
    class Item
    {
        protected bool _hasItem;
        protected string _itemName;

        public bool hasItem
        {
            get { return _hasItem; }
            set { _hasItem = value; }
        }

        public string itemName
        {
            get { return _itemName; }
        }
    }
}
