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
            _itemList[0] = new Item(5, "Knife");
            _itemList[1] = new Item(5, "hat");
            _itemList[2] = new Item(5, "Shirt");
            _itemList[3] = new Item(45, "Obsidian Shield");
            _itemList[4] = new Item(50, "Sword of Chaos");
        }

        //Returns the value of the _gold variable
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

        //Gives access to the inventory of the chracter
        public Item[] GetItemList()
        {
            return _itemList;
        }

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

        public Item[] Remove(int index)
        {
            Item[] newList = new Item[_itemList.Length - 1];

            int n = 0;

            for(int i = 0; i < newList.Length; i++)
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
