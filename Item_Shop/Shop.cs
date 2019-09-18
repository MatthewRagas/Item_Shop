using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item_Shop
{
    class Shop
    {
        private ShopKeeper _merchant;
        private Character _player;

        public Shop(Character player, ShopKeeper merchant)
        {
            _player = player;
            _merchant = merchant;
        }
        public void ShopMenu()
        {
            Console.WriteLine("Welcome " + _player.GetName() + "!");
            string choice = "";
            while(choice != "0")
            {
                
                Console.WriteLine("what would you like to do?");
                Console.WriteLine("0: Exit\n1: Buy\n2: Sell");
                choice = Console.ReadLine();

                if (choice == "0")
                {
                    return;
                }
                else if(choice == "1")
                {
                    BuyingMenu(_merchant, _player);
                }
                else if(choice == "2")
                {
                    SellingMenu(_merchant, _player);
                }
            }            
        }
        public void BuyingMenu(ShopKeeper merchant, Character player)
        {           
            Console.WriteLine("What would you like to purchase?\n");
            for (int i = 0; i < merchant.GetInventory().GetItemList().Length; i++)
            {
                Console.WriteLine((i + 1) + ": " + merchant.GetInventory().GetItemList()[i].GetName());
                Console.WriteLine("Gold: " + merchant.GetInventory().GetItemList()[i].GetValue() + "\n");

            }
        }
        public void SellingMenu(ShopKeeper merchant, Character player)
        {
            Console.WriteLine("What would you like to sell?\n");
            for (int i = 0; i < player.GetPlayerInventory().GetItemList().Length; i++)
            {
                Console.WriteLine((i + 1) + ": " + player.GetPlayerInventory().GetItemList()[i].GetName());
                Console.WriteLine("Gold: " + player.GetPlayerInventory().GetItemList()[i].GetValue() + "\n");

            }
        }
    }
}
