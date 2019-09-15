using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item_Shop
{
    class ShopInventory
    {
        private Item[] _itemList = new Item[8];
        private int _gold = 1500;

        public ShopInventory()
        {
            _itemList[0] = new Item(1, "Rags");
            _itemList[1] = new Item(75, "Leather Armor");
            _itemList[2] = new Item(50, "Wooden Shield");
            _itemList[3] = new Item(50, "Long Sword");
            _itemList[4] = new Item(10, "Gloves");
            _itemList[5] = new Item(15, "Leather Boots");
            _itemList[6] = new Item(3, "Brownies");
            _itemList[7] = new Item(8, "God's Chosen Chicken Sandwich");
        }
        public int GetGold()
        {
            return _gold;
        }

        public Item[] GetItemList()
        {            
            return _itemList;
        }
    }
}
