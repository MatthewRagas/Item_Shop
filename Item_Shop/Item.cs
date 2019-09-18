using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item_Shop
{
    class Item
    {

        //Gold variable
        protected int _value;

        //Name variable
        protected string _name;

        //Constructor of base items
        public Item(int value, string name)
        {
            _value = value;
            _name = name;
        }

        //Function to return item name
        public string GetName()
        {
            return _name;
        }

        //Function to return item gold value
        public int GetValue()
        {
            return _value;
        }
    }
}
