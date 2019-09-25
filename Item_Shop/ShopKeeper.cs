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

        //Returns the name of the shop keeper
        public string GetName
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }            
        }
       
        //Returns the shop inventory variable of the shop keeper.
        public ShopInventory GetInventory()
        {
            return _shop;
        } 
                
    }
}
