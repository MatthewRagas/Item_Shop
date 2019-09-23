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

        public Consumables(string newName, int newHealing, int newValue, string newDescription)
        {
            _name = newName;
            _healing = newHealing;
            _value = newValue;
            _description = newDescription;
        }
    }
}
