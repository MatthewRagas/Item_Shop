using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item_Shop
{
    class ShopInventory
    {
        private Item[] _itemList; 
        private int _gold = 1500;

        //Constructor for the shop's inventory
        public ShopInventory()
        {
            _itemList = new Item[8];
            _itemList[0] = new DefenseItem("Rags", 0, 1, 2, "Used to lcean yourself up.");
            _itemList[1] = new DefenseItem("Leather Armor", 20, 45, 2, "Standard training gear.");
            _itemList[2] = new DefenseItem("Wooden Shield", 5, 10, 2, "Standard trainging gear.");
            _itemList[3] = new AttackItem("Long Sword", 16, 55, 1, "For the more adept warrior.");
            _itemList[4] = new DefenseItem("Gloves", 0, 5, 2, "It's chilly outside.");
            _itemList[5] = new DefenseItem("Leather Boots", 10, 25, 2, "Standard training gear.");
            _itemList[6] = new Consumables("Brownies", 15, 3, 3, "Warm and fluffy. Just like mother used to make them.");
            _itemList[7] = new Consumables("God's Chosen Chicken Sandwich", 777, 10, 3, "This chicken has been embued with the power on high and brings new life to you.");
        }

        public ShopInventory(Item[] newList)
        {
            _itemList = newList;
        }

        //Returns the item array list.
        public Item[] GetItemList
        {
            set
            {
                _itemList = value;
            }
            get
            {
                return _itemList;
            }            
        }

        //Returns the value of the gold variable for the shop keeper
        public int Gold
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
        public int InventoryLength
        {
            set
            {
                _itemList = new Item[value];
            }
            get
            {
                return _itemList.Length;
            }
        }

        //Adds an item to the shop inventory
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

        //Removes an item from the shop inventory
        public Item[] Remove(int index)
        {
            Item[] newList = new Item[_itemList.Length - 1];

            int n = 0;

            for (int i = 0; i < _itemList.Length; i++)
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
