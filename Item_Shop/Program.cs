using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Item[] itemList =
            Character player = new Character("Player1");
            ShopKeeper merchant = new ShopKeeper();
            Shop weaponStore = new Shop(player, merchant);
            player.LoadPlayer("Player.txt");
            merchant.LoadMerchant("Shop.txt");
            if(player.GetName == "Player1")
            {
                Console.WriteLine("Name your character before entering the shop.\n");
                player.GetName = Console.ReadLine();
            }
            weaponStore.ShopMenu();
            player.SavePlayer("Player.txt");
            merchant.SaveMerchant("Shop.txt");            
            Console.ReadKey();
        }        
    }
}
