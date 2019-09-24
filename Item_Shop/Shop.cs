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
            Console.Clear();
            Console.WriteLine("Welcome " + _player.GetName() + "!");
            string choice = "";
            while(choice != "0")
            {                
                Console.WriteLine("what would you like to do?");
                Console.WriteLine("0: Exit\n1: Buy\n2: Sell\n");
                Console.WriteLine(_player.GetName() + ": " + _player.GetInventory().Gold + "        " + _merchant.GetName() + ": " + _merchant.GetInventory().Gold);
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
                else if(choice == "SUPER USER")
                {
                    UserEditingMenu(_merchant, _player);
                }
            }            
        }

        //Displays possible items that can be bought from the shop inventory
        public void BuyingMenu(ShopKeeper merchant, Character player)
        {
            Console.Clear();
            Console.WriteLine("What would you like to purchase?\n");            
            if(merchant.GetInventory().GetItemList().Length > 0)
            {
                Console.WriteLine("0: Exit\n");

                //Iterates through the shop inventory array to display info to the user.
                for (int i = 0; i < merchant.GetInventory().GetItemList().Length; i++)
                {
                    Console.WriteLine((i + 1) + ": " + merchant.GetInventory().GetItemList()[i].GetName());
                    Console.WriteLine("Gold: " + merchant.GetInventory().GetItemList()[i].GetValue() + "\n");
                }
                Console.WriteLine(player.GetName() + ": " + player.GetInventory().Gold + "        " + merchant.GetName() + ": " + merchant.GetInventory().Gold);
                int choice = Convert.ToInt32(Console.ReadLine());

                if(choice == 0)
                {
                    return;
                }
                PlayerBuying(merchant, player, choice - 1);
            }
            Console.Clear();
        }

        //Displays possible items that can be sold from player inventory
        public void SellingMenu(ShopKeeper merchant, Character player)
        {
            Console.Clear();
            Console.WriteLine("What would you like to sell?\n");

            Console.WriteLine("0: Exit\n");

            //Iterates through the player Inventory to display info to the user
            if(player.GetInventory().GetItemList().Length > 0)
            {
                for (int i = 0; i < player.GetInventory().GetItemList().Length; i++)
                {
                    Console.WriteLine((i + 1) + ": " + player.GetInventory().GetItemList()[i].GetName());
                    Console.WriteLine("Gold: " + player.GetInventory().GetItemList()[i].GetValue() + "\n");
                }
                Console.WriteLine(player.GetName() + ": " + player.GetInventory().Gold + "        " + merchant.GetName() + ": " + merchant.GetInventory().Gold);
                int choice = Convert.ToInt32(Console.ReadLine());
                PlayerSelling(merchant, player, choice - 1);
            }
            Console.Clear();
        }

        //Decrements the gold variable of the player by the value of the item purchased.
        //and gives the merchant that amount of gold
        public void PlayerBuying(ShopKeeper merchant, Character player, int choice)
        {

            //Allows player to buy item if they have enough gold
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

            if(merchant.GetInventory().Gold > player.GetInventory().GetItemList()[choice].GetValue())
            {
                //Gold is added to the player and subtracted from the merchant
                merchant.GetInventory().Gold -= player.GetInventory().GetItemList()[choice].GetValue();
                player.GetInventory().Gold += player.GetInventory().GetItemList()[choice].GetValue();

                //Player item is added to shop inventory and removed from player inventory
                merchant.GetInventory().Add(player.GetInventory().GetItemList()[choice]);
                player.GetInventory().Remove(choice);
            }            

            
        }
        
        //Displays options for the super user
        public void UserEditingMenu(ShopKeeper merchant, Character player)
        {
            string choice = "";
            while (choice != "0")
            {
                Console.Clear();
                Console.WriteLine("Welcome Super User\n What would you like to do?");
                Console.WriteLine("0: Exit User Editing\n1: Add\n2: Remove");

                choice = Console.ReadLine();

                if (choice == "0")
                {
                    return;
                }
                else if(choice == "1")
                {
                    AddMenu(merchant, player);
                }
                else if(choice == "2")
                {
                    RemoveMenu(merchant, player);
                }
            }
        }

        //Displays the options for wha the super user wants to add
        public void AddMenu(ShopKeeper merchant, Character player)
        {
            Console.Clear();            
            string choice = "";

            while(choice != "0")
            {
                Console.WriteLine("Would you like to add to\n0: Exit\n1: Shop Inventory\n2: Character Inventory");

                choice = Console.ReadLine();

                if(choice == "0")
                {
                    return;
                }
                else if(choice == "1")
                {
                    ShopAdd(merchant);
                }
                else if(choice == "2")
                {
                    PlayerAdd(player);
                }
            }
        }

        //Displays the options for what the super user wants to remove
        public void RemoveMenu(ShopKeeper merchant, Character player)
        {
            Console.Clear();
            string choice = "";

            while (choice != "0")
            {
                Console.WriteLine("Would you like to remove from\n0: Exit\n1: Shop Inventory\n2: Character Inventory");

                choice = Console.ReadLine();

                if (choice == "0")
                {
                    return;
                }
                else if (choice == "1")
                {
                    ShopRemove(merchant);
                }
                else if (choice == "2")
                {
                    PlayerRemove(player);
                }
            }
        }

        //Allows the super user to add items and gold to the shop inventory
        public void ShopAdd(ShopKeeper merchant)
        {
            Console.Clear();
            string choice = "";

            while (choice != "0")
            {
                Console.Clear();
                Console.WriteLine("What do you want to add?\n0: Exit\n1: Defense Item\n2: Attack Item\n3: Consumable\n4: Gold");

                choice = Console.ReadLine();

                if (choice == "0")
                {
                    return;
                }
                else if (choice == "1")
                {
                    Console.Clear();
                    Console.WriteLine("In order to add a defense item you need to \ninput the item's: 'Name', 'Defense stat, 'Gold value', and then 'Description'\nPress enter after you input each paramater");
                    merchant.GetInventory().Add(new DefenseItem(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Console.ReadLine()));
                }
                else if (choice == "2")
                {
                    Console.Clear();
                    Console.WriteLine("In order to add an attack item you need to \ninput the item's: 'Name', 'Damage stat', 'Gold vlaue', and the 'Description'\nPress enter after you input each paramater");
                    merchant.GetInventory().Add(new AttackItem(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Console.ReadLine()));
                }
                else if (choice == "3")
                {
                    Console.Clear();
                    Console.WriteLine("In order to add a consumable item you need to \ninput the item's: 'Name', 'healing amount', 'Gold value', and then 'Description'");
                    merchant.GetInventory().Add(new Consumables(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Console.ReadLine()));
                }
                else if (choice == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Input how much gold you want to add to the merchant.");
                    Console.WriteLine("Current gold: " + merchant.GetInventory().Gold + "\n");
                    int newGold = (Convert.ToInt32(Console.ReadLine()));
                    merchant.GetInventory().Gold += newGold;
                }
            }

        }

        //Allows the super user to add items and gold to user inventory
        public void PlayerAdd(Character player)
        {
            Console.Clear();
            string choice = "";

            while (choice != "0")
            {
                Console.Clear();
                Console.WriteLine("What do you want to add?\n0: Exit\n1: Defense Item\n2: Attack Item\n3: Consumable\n4: Gold");

                choice = Console.ReadLine();

                if (choice == "0")
                {
                    return;
                }
                else if (choice == "1")
                {
                    Console.Clear();
                    Console.WriteLine("In order to add a defense item you need to \ninput the item's: 'Name', 'Defense stat, 'Gold value', and then 'Description'\nPress enter after you input each paramater");

                    //Uses the add function of the player to add a new item into the player's inventory
                    player.GetInventory().Add(new DefenseItem(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Console.ReadLine()));
                }
                else if (choice == "2")
                {
                    Console.Clear();
                    Console.WriteLine("In order to add an attack item you need to \ninput the item's: 'Name', 'Damage stat', 'Gold vlaue', and the 'Description'\nPress enter after you input each paramater");

                    //Uses the add function of the player to add a new item into the player's inventory
                    player.GetInventory().Add(new AttackItem(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Console.ReadLine()));
                }
                else if (choice == "3")
                {
                    Console.Clear();
                    Console.WriteLine("In order to add a consumable item you need to \ninput the item's: 'Name', 'healing amount', 'Gold value', and then 'Description'");

                    //Uses the add function of the player to add a new item into the player's inventory
                    player.GetInventory().Add(new Consumables(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Console.ReadLine()));
                }
                else if (choice == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Input how much gold you want to add to the player.");
                    Console.WriteLine("Current gold: " + player.GetInventory().Gold + "\n");
                    int newGold = (Convert.ToInt32(Console.ReadLine()));

                    //Adds gold to the player
                    player.GetInventory().Gold += newGold;
                }
            }
        }

        public void ShopRemove(ShopKeeper merchant)
        {
            Console.Clear();

            Console.WriteLine("What would you like to remove from the shop inventory?");

            Console.WriteLine("0: Exit\n");

            //Iterates through the shop inventory array to display info to the user.
            for (int i = 0; i < merchant.GetInventory().GetItemList().Length; i++)
            {
                Console.WriteLine((i + 1) + ": " + merchant.GetInventory().GetItemList()[i].GetName());             
            }

            int choice = Convert.ToInt32(Console.ReadLine()) - 1;

            merchant.GetInventory().Remove(choice);
        }

        public void PlayerRemove(Character player)
        {
            Console.Clear();

            Console.WriteLine("What would you like to remove from the player inventory?");

            Console.WriteLine("0: Exit\n");

            //Iterates through the shop inventory array to display info to the user.
            for (int i = 0; i < player.GetInventory().GetItemList().Length; i++)
            {
                Console.WriteLine((i + 1) + ": " + player.GetInventory().GetItemList()[i].GetName());
            }

            int choice = Convert.ToInt32(Console.ReadLine()) - 1;

            player.GetInventory().Remove(choice);
        }
    }    
}
