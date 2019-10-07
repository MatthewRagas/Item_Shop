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
        private int _itemID;

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
        public override int GetID
        {
            set
            {
                _itemID = value;
            }
            get
            {
                return _itemID;
            }
        }

        //Construcotr for defense items
        public DefenseItem(string newName, int newDefense, int newValue, int newItemID, string newDescription)
        {
            _name = newName;
            _defense = newDefense;
            _value = newValue;
            _itemID = newItemID;
            _description = newDescription;
            if(_value < 0)
            {
                _value = 0;
            }
        }
    }
}
