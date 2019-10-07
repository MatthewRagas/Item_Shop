using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item_Shop
{
    class Consumables : Item
    {
        private int _healing;
        private int _itemID;

        //Constructor for consumable items
        public Consumables(string newName, int newHealing, int newValue, int newItemID, string newDescription)
        {
            _name = newName;
            _healing = newHealing;
            _value = newValue;
            _itemID = newItemID;
            _description = newDescription;
            if (_value < 0)
            {
                _value = 0;
            }
        }

        public override int GetHealing
        {
            set
            {
                _healing = value;
            }
            get
            {
                return _healing;
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

    }
}
