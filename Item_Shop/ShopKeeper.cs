using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item_Shop
{
    class ShopKeeper
    {
        private string _name = "store merchant";
        
        private ShopInventory _shop = new ShopInventory();

        public string GetName()
        {
            return _name;
        }

        public ShopInventory GetInventory()
        {
            return _shop;
        }
       
    }
}
