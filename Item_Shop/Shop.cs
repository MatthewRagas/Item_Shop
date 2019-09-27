using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            Console.WriteLine("Welcome " + _player.GetName + "!");
            string choice = "";
            while(choice != "0")
            {
                Console.Clear();
                Console.WriteLine("what would you like to do?");
                Console.WriteLine("0: Exit\n1: Buy\n2: Sell\n");
                Console.WriteLine(_player.GetName + ": " + _player.GetInventory().Gold + "        " + _merchant.GetName + ": " + _merchant.GetInventory().Gold);
                choice = Console.ReadLine();

                if (choice == "0")
                {
                    return;
                }
                else if(choice == "1")
                {
                    BuyingMenu();
                }
                else if(choice == "2")
                {
                    SellingMenu();
                }
                else if(choice == "SUPER USER")
                {
                    UserEditingMenu();
                }                
            }            
        }

        //Displays possible items that can be bought from the shop inventory
        public void BuyingMenu()
        {
            Console.Clear();
            Console.WriteLine("What would you like to purchase?\n");            
            if(_merchant.GetInventory().GetItemList.Length > 0)
            {
                Console.WriteLine("0: Exit\n");

                //Iterates through the shop inventory array to display info to the user.
                for (int i = 0; i < _merchant.GetInventory().GetItemList.Length; i++)
                {
                    Console.WriteLine((i + 1) + ": " + _merchant.GetInventory().GetItemList[i].GetName);
                    Console.WriteLine("Gold: " + _merchant.GetInventory().GetItemList[i].GetValue + "\n");
                }
                Console.WriteLine(_player.GetName + ": " + _player.GetInventory().Gold + "        " + _merchant.GetName + ": " + _merchant.GetInventory().Gold);
                int choice = Convert.ToInt32(Console.ReadLine());

                if(choice == 0)
                {
                    return;
                }
                PlayerBuying(choice - 1);
            }
            Console.Clear();
        }

        //Displays possible items that can be sold from player inventory
        public void SellingMenu()
        {
            Console.Clear();
            Console.WriteLine("What would you like to sell?\n");

            Console.WriteLine("0: Exit\n");

            //Iterates through the player Inventory to display info to the user
            if(_player.GetInventory().GetItemList.Length > 0)
            {
                for (int i = 0; i < _player.GetInventory().GetItemList.Length; i++)
                {
                    Console.WriteLine((i + 1) + ": " + _player.GetInventory().GetItemList[i].GetName);
                    Console.WriteLine("Gold: " + _player.GetInventory().GetItemList[i].GetValue + "\n");
                }
                Console.WriteLine(_player.GetName + ": " + _player.GetInventory().Gold + "        " + _merchant.GetName + ": " + _merchant.GetInventory().Gold);
                int choice = Convert.ToInt32(Console.ReadLine());

                if(choice == 0)
                {
                    return;
                }
                else
                {
                    PlayerSelling(choice - 1);
                }                
            }
            Console.Clear();
        }

        //Decrements the gold variable of the player by the value of the item purchased.
        //and gives the merchant that amount of gold
        public void PlayerBuying(int choice)
        {

            //Allows player to buy item if they have enough gold
            if(_player.GetInventory().Gold >= _merchant.GetInventory().GetItemList[choice].GetValue)
            {
                _player.GetInventory().Gold -= _merchant.GetInventory().GetItemList[choice].GetValue;
                _merchant.GetInventory().Gold += _merchant.GetInventory().GetItemList[choice].GetValue;

                _player.GetInventory().Add(_merchant.GetInventory().GetItemList[choice]);
                _merchant.GetInventory().Remove(choice);
            }
            else
            {
                Console.WriteLine("You do not have enought gold to buy that. \n");
            }                        
        }

        //Decrements the gold variable of the merchant by the value of the item sold and gives the player
        //that amount of gold.
        public void PlayerSelling(int choice)
        {
            
            if(_merchant.GetInventory().Gold >= _player.GetInventory().GetItemList[choice].GetValue)
            {
                //Gold is added to the player and subtracted from the merchant
                _merchant.GetInventory().Gold -= _player.GetInventory().GetItemList[choice].GetValue;
                _player.GetInventory().Gold += _player.GetInventory().GetItemList[choice].GetValue;

                //Player item is added to shop inventory and removed from player inventory
                _merchant.GetInventory().Add(_player.GetInventory().GetItemList[choice]);
                _player.GetInventory().Remove(choice);
            }
            else if(_merchant.GetInventory().Gold < _player.GetInventory().GetItemList[choice].GetValue)
            {
                Console.Clear();
                Console.WriteLine("The " + _merchant.GetName + " only has: " + _merchant.GetInventory().Gold + "\nItem value: " + _player.GetInventory().GetItemList[choice].GetValue + "\n1: Sell anyways? \nEnter: Cancel");
                string decide = Console.ReadLine();

                if(decide == "1")
                {
                    _player.GetInventory().Gold += _merchant.GetInventory().Gold;
                    _merchant.GetInventory().Gold -= _merchant.GetInventory().Gold;
                }
                else
                {
                    return;
                }
            }           
        }
        
        //Displays options for the super user
        public void UserEditingMenu()
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
                    AddMenu();
                }
                else if(choice == "2")
                {
                    RemoveMenu();
                }
            }
        }

        //Displays the options for wha the super user wants to add
        public void AddMenu()
        {
                      
            string choice = "";

            while(choice != "0")
            {
                Console.Clear();
                Console.WriteLine("Would you like to add to\n0: Exit\n1: Shop Inventory\n2: Character Inventory");

                choice = Console.ReadLine();

                if(choice == "0")
                {
                    return;
                }
                else if(choice == "1")
                {
                    ShopAdd();
                }
                else if(choice == "2")
                {
                    PlayerAdd();
                }
            }
        }

        //Displays the options for what the super user wants to remove
        public void RemoveMenu()
        {
            
            string choice = "";

            while (choice != "0")
            {
                Console.Clear();
                Console.WriteLine("Would you like to remove from\n0: Exit\n1: Shop Inventory\n2: Character Inventory");

                choice = Console.ReadLine();

                if (choice == "0")
                {
                    return;
                }
                else if (choice == "1")
                {
                    ShopRemove();
                }
                else if (choice == "2")
                {
                    PlayerRemove();
                }
            }
        }

        //Allows the super user to add items and gold to the shop inventory
        public void ShopAdd()
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
                    _merchant.GetInventory().Add(new DefenseItem(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), 2, Console.ReadLine()));
                }
                else if (choice == "2")
                {
                    Console.Clear();
                    Console.WriteLine("In order to add an attack item you need to \ninput the item's: 'Name', 'Damage stat', 'Gold vlaue', and the 'Description'\nPress enter after you input each paramater");
                    _merchant.GetInventory().Add(new AttackItem(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), 1, Console.ReadLine()));
                }
                else if (choice == "3")
                {
                    Console.Clear();
                    Console.WriteLine("In order to add a consumable item you need to \ninput the item's: 'Name', 'healing amount', 'Gold value', and then 'Description'");
                    _merchant.GetInventory().Add(new Consumables(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), 3, Console.ReadLine()));
                }
                else if (choice == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Input how much gold you want to add to the merchant.");
                    Console.WriteLine("Current gold: " + _merchant.GetInventory().Gold + "\n");
                    int newGold = (Convert.ToInt32(Console.ReadLine()));
                    _merchant.GetInventory().Gold += newGold;
                }
            }

        }

        //Allows the super user to add items and gold to user inventory
        public void PlayerAdd()
        {            
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
                    _player.GetInventory().Add(new DefenseItem(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), 2, Console.ReadLine()));
                }
                else if (choice == "2")
                {
                    Console.Clear();
                    Console.WriteLine("In order to add an attack item you need to \ninput the item's: 'Name', 'Damage stat', 'Gold vlaue', and the 'Description'\nPress enter after you input each paramater");

                    //Uses the add function of the player to add a new item into the player's inventory
                    _player.GetInventory().Add(new AttackItem(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), 1, Console.ReadLine()));
                }
                else if (choice == "3")
                {
                    Console.Clear();
                    Console.WriteLine("In order to add a consumable item you need to \ninput the item's: 'Name', 'healing amount', 'Gold value', and then 'Description'");

                    //Uses the add function of the player to add a new item into the player's inventory
                    _player.GetInventory().Add(new Consumables(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), 3, Console.ReadLine()));
                }
                else if (choice == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Input how much gold you want to add to the player.");
                    Console.WriteLine("Current gold: " + _player.GetInventory().Gold + "\n");
                    int newGold = (Convert.ToInt32(Console.ReadLine()));

                    //Adds gold to the player
                    _player.GetInventory().Gold += newGold;
                }
            }
        }

        public void ShopRemove()
        {
            Console.Clear();

            Console.WriteLine("What would you like to remove from the shop inventory?");

            Console.WriteLine("0: Exit\n");

            //Iterates through the shop inventory array to display info to the user.
            for (int i = 0; i < _merchant.GetInventory().GetItemList.Length; i++)
            {
                Console.WriteLine((i + 1) + ": " + _merchant.GetInventory().GetItemList[i].GetName);             
            }

            int choice = Convert.ToInt32(Console.ReadLine()) - 1;

            _merchant.GetInventory().Remove(choice);
        }

        public void PlayerRemove()
        {
            Console.Clear();

            Console.WriteLine("What would you like to remove from the player inventory?");

            Console.WriteLine("0: Exit\n");

            //Iterates through the shop inventory array to display info to the user.
            for (int i = 0; i < _player.GetInventory().GetItemList.Length; i++)
            {
                Console.WriteLine((i + 1) + ": " + _player.GetInventory().GetItemList[i].GetName);
            }

            int choice = Convert.ToInt32(Console.ReadLine()) - 1;

            _player.GetInventory().Remove(choice);
        }                
    }    
}
