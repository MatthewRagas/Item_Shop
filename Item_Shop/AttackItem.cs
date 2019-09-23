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

        //Property to reference the _damage variable
        public int Damage
        {
            get
            {
                return _damage;
            }
        }

        //Constructor for the attack items
        public AttackItem(string newName, int newDamage, int newValue, string newDescription)
        {
            _name = newName;
            _damage = newDamage;
            _value = newValue;
            _description = newDescription;
        }
    }
}
