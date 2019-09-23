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
        protected int _value = 1;

        //Name variable
        protected string _name = "";                

        protected string _description;
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
