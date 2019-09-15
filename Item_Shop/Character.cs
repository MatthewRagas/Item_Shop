using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item_Shop
{
    class Character
    {
        private PlayerInventory _bag = new PlayerInventory();
        
        private string _name;

        public Character(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }
        public PlayerInventory GetPlayerInventory()
        {
            return _bag;
        }
        
    }
}
