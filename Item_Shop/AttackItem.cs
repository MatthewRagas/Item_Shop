using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item_Shop
{
    class AttackItem : Item
    {
        private int _damage;
        private int _itemID;

        //Property to reference the _damage variable
        public override int GetAttack
        {
            set
            {
                _damage = value;
            }
            get
            {
                return _damage;
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

        //Constructor for the attack items
        public AttackItem(string newName, int newDamage, int newValue, int newItemID, string newDescription)
        {
            _name = newName;
            _damage = newDamage;
            _value = newValue;
            _itemID = newItemID;
            _description = newDescription;
            if (_value < 0)
            {
                _value = 0;
            }
        }


    }
}
