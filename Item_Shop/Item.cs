using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item_Shop
{
    class Item
    {
        protected int _value;
        protected string _name;
        public Item(int value, string name)
        {
            _value = value;
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetValue()
        {
            return _value;
        }
    }
}
