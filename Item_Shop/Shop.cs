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


        //Constructor for the Shop passes in a player and a shop keeper.
        public Shop(Character player, ShopKeeper merchant)
        {
            _player = player;
            _merchant = merchant;
        }

        //Brings up the Shop menu options for the player to choose from
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

        //Displays possible items that can be bought from the shop inventory
        public void BuyingMenu(ShopKeeper merchant, Character player)
        {           
            Console.WriteLine("What would you like to purchase?\n");
            
            for (int i = 0; i < merchant.GetInventory().GetItemList().Length; i++)
            {
                Console.WriteLine((i + 1) + ": " + merchant.GetInventory().GetItemList()[i].GetName());
                Console.WriteLine("Gold: " + merchant.GetInventory().GetItemList()[i].GetValue() + "\n");

            }

            int choice = Convert.ToInt32(Console.ReadLine());
                       
            PlayerBuying(merchant, player, choice - 1);
        }

        //Displays possible items that can be sold from player inventory
        public void SellingMenu(ShopKeeper merchant, Character player)
        {
            Console.WriteLine("What would you like to sell?\n");
            for (int i = 0; i < player.GetInventory().GetItemList().Length; i++)
            {
                Console.WriteLine((i + 1) + ": " + player.GetInventory().GetItemList()[i].GetName());
                Console.WriteLine("Gold: " + player.GetInventory().GetItemList()[i].GetValue() + "\n");

            }

            int choice = Convert.ToInt32(Console.ReadLine());

            PlayerSelling(merchant, player, choice - 1);
        }

        //Decrements the gold variable of the player by the value of the item purchased.
        //and gives the merchant that amount of gold
        public void PlayerBuying(ShopKeeper merchant, Character player, int choice)
        {
            if(player.GetInventory().Gold >= merchant.GetInventory().GetItemList()[choice].GetValue())
            {
                player.GetInventory().Gold -= merchant.GetInventory().GetItemList()[choice].GetValue();
                merchant.GetInventory().Gold += merchant.GetInventory().GetItemList()[choice].GetValue();

                player.GetInventory().Add(merchant.GetInventory().GetItemList()[choice]);
                merchant.GetInventory().Remove(choice);
            }
            else
            {
                Console.WriteLine("You do not have enought gold to buy that. \n");
            }
            
            
        }

        //Decrements the gold variable of the merchant by the value of the item sold and gives the player
        //that amount of gold.
        public void PlayerSelling(ShopKeeper merchant, Character player, int choice)
        {
            merchant.GetInventory().Gold -= player.GetInventory().GetItemList()[choice].GetValue();
            player.GetInventory().Gold += player.GetInventory().GetItemList()[choice].GetValue();

            merchant.GetInventory().Add(player.GetInventory().GetItemList()[choice]);
            player.GetInventory().Remove(choice);
        }        
    }
}
