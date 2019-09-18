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

        public CharacterInventory()
        {
            _itemList[0] = new Item(5, "Knife");
            _itemList[1] = new Item(5, "hat");
            _itemList[2] = new Item(5, "Shirt");
            _itemList[3] = new Item(45, "Obsidian Shield");
            _itemList[4] = new Item(50, "Sword of Chaos");
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
