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

        public Character(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }
        public CharacterInventory GetPlayerInventory()
        {
            return _bag;
        }
        
    }
}
