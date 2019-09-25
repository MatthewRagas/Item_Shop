using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item_Shop
{
    class CharacterInventory
    {
        private Item[] _itemList = new Item[5];
        private int _gold = 1000;


        //Constructor for the character Inventory
        public CharacterInventory()
        {
            _itemList[0] = new AttackItem("Knife", 7, 5, 1, "Nothing is as light weight as a knife, allowing for quick and precise strikes");
            _itemList[1] = new DefenseItem("Steel Helm", 30, 75, 2, "It would be wise to not leave the head unprotected. This works...I guess.");
            _itemList[2] = new DefenseItem("Steel Shield", 25, 60, 2, "A good steel shield for a good strong mercenary");
            _itemList[3] = new DefenseItem("Obsidian Shield", 80, 300, 2, "Everyone knows the heat of Mt. Ranja's lava cannot be cooled, but somehow, some ancient creature possessed this capability and with it, allowed for such a shield to be made.");
            _itemList[4] = new AttackItem("Sword of Chaos", 85, 1500, 1, "This sword was forged in the blood of battle. As you take hold of it, it almost feels like it's taking hold of you.");
        }

        //Returns the value of the _gold variable
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

        //Gives access to the inventory of the chracter
        public Item[] GetItemList()
        {
            return _itemList;
        }

        //Adds an item to the character inventory
        public Item[] Add(Item item)
        {
            Item[] newInventory = new Item[_itemList.Length + 1];

            for(int i = 0; i < _itemList.Length; i++)
            {
                newInventory[i] = _itemList[i];
            }

            newInventory[newInventory.Length - 1] = item;

            _itemList = newInventory;

            return _itemList;
        }

        //Removes an item from the character inventory
        public Item[] Remove(int index)
        {
            Item[] newList = new Item[_itemList.Length - 1];

            int n = 0;

            for(int i = 0; i < _itemList.Length; i++)
            {
                if(i != index)
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
