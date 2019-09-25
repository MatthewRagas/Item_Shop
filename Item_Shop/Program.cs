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
            Character character = new Character("test");
            var test = character;
            
            Console.WriteLine("Name your Character before you enter the shop.");
            Character player = new Character(Console.ReadLine());
            ShopKeeper merchant = new ShopKeeper();
            Shop store = new Shop(player, merchant);
            player.LoadPlayer("Shop.txt");
            store.ShopMenu();
            player.SavePlayer("Player.txt");
            Console.ReadKey();
        }        
    }
}
