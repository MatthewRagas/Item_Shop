using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item_Shop
{
    class Character
    {
        private CharacterInventory _bag = new CharacterInventory();
        
        private string _name;

        //Constructor for characters that passes in a string for a name
        public Character(string name)
        {
            _name = name;
        }

        //Returns the name variable of the character
        public string GetName()
        {
            return _name;
        }

        //Returns the Character Inventory variable of the character
        public CharacterInventory GetInventory()
        {
            return _bag;
        }   
               
    }
}
