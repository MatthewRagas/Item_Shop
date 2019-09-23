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
            Console.WriteLine("Name your Character before you enter the shop.");
            Character player = new Character(Console.ReadLine());
            ShopKeeper merchant = new ShopKeeper();
            Shop store = new Shop(player, merchant);
            store.ShopMenu();
            Console.ReadKey();
        }        
    }
}
