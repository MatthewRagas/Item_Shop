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

        //Constructor for the shop's inventory
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

        //Returns the item array list.
        public Item[] GetItemList()
        {            
            return _itemList;
        }

        //Returns the value of the gold variable for the shop keeper
        public int GetGold
        {
            set
            {
                _gold = value;
            }
            get
            {
                return _gold;
            }            
        }

        public Item[] Add(Item item)
        {
            Item[] newInventory = new Item[_itemList.Length + 1];

            for (int i = 0; i < _itemList.Length; i++)
            {
                newInventory[i] = _itemList[i];
            }

            newInventory[newInventory.Length - 1] = item;

            _itemList = newInventory;

            return _itemList;
        }

        public Item[] Remove(int index)
        {
            Item[] newList = new Item[_itemList.Length - 1];

            int n = 0;

            for (int i = 0; i < newList.Length; i++)
            {
                if (i != index)
                {
                    newList[n] = _itemList[i];
                    n++;
                }
            }

            _itemList = newList;

            return _itemList;
        }
    }
}
