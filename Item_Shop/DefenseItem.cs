using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item_Shop
{
    class DefenseItem : Item
    {
        private int _defense;
        

        //Property to reference the _defense variable
        public override int GetDefense
        {
            set
            {
                _defense = value;
            }
            get
            {
                return _defense;
            }
        }

        //Construcotr for defense items
        public DefenseItem(string newName, int newDefense, int newValue, string newDescription)
        {
            _name = newName;
            _defense = newDefense;
            _value = newValue;
            _description = newDescription;
        }
    }
}
