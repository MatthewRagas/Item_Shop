| Matthew Ragas |

| s178023 |
| Item Shop Assessment |
| Item Shop Documentation |

## I. Requirements

1. Description of Problem

    - **Name**: Item Shop

    - **Problem Statement**:
    Creation of a store using C# programming language in wich the user can buy items from the Computer's inventory, or sell items to the computer from the user's own inventory.

    - **Problem Specifications**:
    The store simulation will maintain an inventory of items, from which the player can select. Your player will also have an inventory of items. The player can add to their inventory by purchasing items from the store, or sell an item to the storekeeper.The player will interact with the storekeeper via a series of text commands. For example, the player may type “View Item” to inspect an item, or “Sell Item” to sell an item in their inventory. You will use the C# string class and associated functions to process all commands within your game. You will store each item in an array, and move items between the player’s inventory array and the store’s inventory array as items are bought and sold. Each item will have a description that is printed to the console when the command to view that item is invoked. In your game you need to demonstrate multiple levels of inheritance. Create a Base Item class for which all other items types will inherit from. Items of different subclasses should display different information about the item. You can also allow the user to view all items of a specific type. As a final requirement, your program must save both the player and store inventory to a text file before your program exits, and read the player and store inventories from these text files upon program launch.

2. Inut Information
- The number keys are used to select options presented to the user on the screen.
- The string "SUPER USER" is used to gain access to the user editing menu in order to add and remove items in the program.
- When adding a new item into the game, the user has to input specific info for the new item to be added in.

3. Output Information/User Interface Information
- The program displays many different menus with options for the player to select what to do next:
    - **Name Character**: If the application is starting up for the first time, the user should get a prompt allowing them to name their character.

    - **Shop Menu**: Upon start up or after naming the character, the user is presented with three options to either exit from the application, buy, or sell.

    - **Buying Menu**: Upon selecting the option to buy, the menu changes to display the shop inventory which the user can choose to buy an item from.

    - **Selling Menu**: Upon selecting the option to sell, the menu changes to display the character inventory which the user can choose an item from to sell to the shop.

    - **SUPER USER Menu**: If the user types "SUPER USER" in all caps from the shop menu, they will then be displayed the super user menu. Two options will appear asking if they want to add/remove an item from the application or exit from the super user menu.

    - **Add Menu**: If the user selects the option to add an item, the application will then display to the user if they want to add to the character inventory, the shop inventory, or if they want to exit instead. Upon selecting either of the two options they are then presented with options to add either an attack item, a defense item, a consumable, gold, or to exit. The user can also use the add menu to remove gold if the numbers are input properly.

    - **Adding Item**: If the user decides to add in an attack item, defense item, or a consumable item, they will be displayed with the information necissary to properly add the item into the game.

    - **Remove Menu**: If the user decides to remove an item from application that already exists, they will have displayed to them if they wish to remove from the shop inventory or the character inventory.

    - **Removing Item**: Upon selecting which the user would like to remvoe an item from, either the character inventory or the shop inventory will be displayed. From these menues, the user can decide which item they wish to remove.

## II. Design

1. _System Architecture_

If there are no files saved from this application before startup, the application will first ask the user to name their character before entering the shop. The shop menu is called passing in the character and the shopkeeper as paramaters. The user has two options displayed to them on the shop menu, buy or sell, as well as how much gold the user and the shop keeper have. Depending on which opition the user selects, the character or shop keeper inventory is displayed to the user. The application waits for input from the user as to what item they will be selling or buying. If the input is not 0, which is used to exit the buying and selling menus, the application will execute either the buying or selling function, adding and subtracting gold corresponding with who sold and item and who bought an item.(the character or the shop keeper) The buying or selling menus will continue to be shown as long as the user has not pressed 0 to exit the inventory screen and the inventory that the user is trying to look at is not empty. If the user wishes to become a super user and be able to add and remove items in the application, from the Shop menu, the user must type in "SUPER USER" to gain access to user editing options. The user will be displayed with the options to add or remove items from either the character inventory or the shop inventory. You remain in user editing, super user mode, until you press 0 on the original user editing menu in order to exit from the mode. The application will only close if the user wishes to exit the shop by pressing 0 from the shop menu. Upon application termination the application will automatically save the inventories of the shop keeper and the character.

### Object Information

   **File**: Item.cs

    Description: The base class of all the items in the application and has many overloaded properties to gain access to more specific item characteristics through out the applicaiton.


   **Attributes**

        Name: _value
            Description: Holds the base value of newly created items
            Type: int
            Protection Level: protected

        Name: _name
            Description: Holds the base name of every newly created item
            Type: string
            Protection Level: protected

        Name: _description
            Description: Holds the description of each item
            Type: string
            Protection Level: protected

        Name: GetName
            Description: Overloaded property used to set and get the name of an item.
            Type: string
            Protection Level: public virtual

        Name: GetValue
            Description: Property used to set and get the gold value of an item
            Type: int
            Protection Level: public virtual

        Name: GetAttack
            Description: Property used to set and get the attack damage of attack items
            Type: int
            Protection Level: public virtual

        Name: GetDefense
            Description: Property used to set and get the defense value of defense items
            Type: int
            Protection Level: public virtual

        Name: GetHealing
            Description: Property used to set ad get the healing amount of consumable items
            Type: int
            Protection Level: public virtual

        Name: GetDescription
            Description: Property used to set and get the description of all items
            Type: string
            Protection Level: public

        Name: GetID
            Description: Property used to get the item id of all items
            Type: int
            Protection Level: public virtual

   **File**: AttackItem.cs

    Description: Class used to differentiate attack items from other items in the game.

   **Attributes**

        Name: _damage
            Description: holds the damage value for attack items
            Type: int
            Protection Level: private

        Name: _itemID
            Description: Holds the id value of an attack item id for attack items
            Type: int
            Protection Level: private

        Name: GetAttack
            Description: Overloaded property used to set and get the damage value of an attack item
            Type: int
            Protection Level: public override

        Name: GetID
            Description: Overloaded property used to set and get the Item ID of attack items
            Type: int
            Protection Level: public override

        Name: AttackItem
            Description: Constructor that initializes an attack item
            Protection Level: public

   **File**: Consumables.cs

    Description: Class used to defferentiate Consumables from other items in the game.

   **Attributes**

        Name: _healing
            Description: holds the value of healing for consumable items.
            Type: int
            Protection Level: private

         Name: _itemID
            Description: Holds the id value of a consumable item id for consumable items
            Type: int
            Protection Level: private

        Name: Consumables
            Description: Constructor that initializes a consumable item
            Protection Level: public

        Name: GetHealing
            Description: Overloaded property used to set and get the healing value of an item.
            Type: int
            Protection Level: public override

        Name: GetID
            Description: Overloaded property used to set and get the Item ID of consumable items
            Type: int
            Protection Level: public override

   **File**: DefenseITem.cs

    Description: Class usd to defferentiate Defense items from other items in the game.

   **Attributes**

        Name: _defense
            Description: holds the defense value of defense items
            Type: int
            Protection Level: private

        Name: _itemID
            Description: Holds the id value of defense items
            Type: int
            Protection Level: private

        Name: GetDefense
            Description: Overloaded property used to set and get the defense value of defense items
            Type: int
            Protection Level: public override

        Name: GetID
            Description: Overloaded property used to set and get the item id of defense items
            Type: int
            Protection Level: public override

        Name: DefenseItem
            Description: Constructor used to initialize defense items
            Protection Level: public

   **File**: ShopInventory.cs
    Description: Class used to define what the base shop inventory is and what the shop inventory can partake in.

   **Attributes**

        Name: _itemList
            Description: Used to hold an array of items as the shop's inventory
            Type: Item[]
            Protection Level: private

        Name: _gold
            Description: Used to hold the gold value that the shop keeper has
            Type: int
            Protection Level: private

        Name: ShopInventory
            Description: Constructor used to initialize the default shop inventory
            Protection Level: public

        Name: GetItemList
            Description: Property used to set and get items within the array _itemList
            Type: Item[]
            Protection Level: public

        Name: Gold
            Description: Property used to set and get the gold value of the _gold variable
            Type: int
            Protection Level: public

        Name: InventoryLength
            Description: Property used to get the length of the current _itemList array or to set a new length for the _itemList array
            Type: int
            Protection Level: public

        Name: Add
            Description: Function used to add one new item to the inventory of the shop keeper.
            Type: Item[]
            Protection Level: public
            Paramater Types: Item

        Name: Remove
            Description: Function used to remove one existing item from the inventory of the shop keeper.
            Type: Item[]
            Protection Level: public
            Paramater Types: int

   **File**: ShopKeeper.cs

    Description: Class used to define what a shop keeper is and what they are able to partake in.

   **Attributes**

        Name: _name
            Description: Holds the value of name for shop keeper
            Type: string
            Protection Level: private

        Name: _shop
            Description: used to give the shop keeper an inventory of items
            Type: ShopInventory
            Protection Level: private

        Name: GetName
            Description: Property used to set and get the value of the name for the shop keeper
            Type: string
            Protection Level: public

        Name: GetInventory
            Description: Function used to return the shop keeper's inventory
            Type: ShopInventory
            Protection Level: public

        Name: SaveMerchant
            Description: Used to save the inventory of the shop keeper
            Type: void
            Parameter Types: string
            Protection Level: public

        Name: LoadMerchant
            Description: Used to load in the inventory of the merchant from a previously saved file.
            Type: void
            Parameter Types: string
            Protection Level: public

   **File**: CharacterInventory.cs

    Description: Class used to define what the base character inventory is and what the character inventory can partake in.

   **Attributes**

        Name: _itemList
            Description: Holds the value of all the items in the character inventory in an array
            Type: Item[]
            Protection Level: private

        Name: _gold
            Description: Holds the value of gold the character has in their inventory
            Type: int
            Protection Level: private

        Name: CharacterInventory
            Description: Constructor for the default inventory of the character
            Protection Level: public

        Name: Gold
            Description: Property used to set and get the gold value of character
            Type: int
            Protection Level: public

        Name: InventoryLength
            Description: Property used to set a new character inventory length and get the length of character inventory
            Type: int
            Protection Level: public

        Name: GetItemList
            Description: Property used to set and get items with in the character's inventory
            Type: Item[]
            Protection Level: public

        Name: Add
            Description: Function used to add one item to character inventory
            Type: Ietm[]
            Parameter Types: Item
            Protection Level: public

        Name: Remove
            Description: Funciton used to remove one item from the character inventory
            Type: Item[]
            Parameter Types: int

   **File**: Character.cs

    Description: Class used to define what a character is and what they are able to partake in.

   **Attributes**

        Name: _bag
            Description: Used to hold an item array for character inventory
            Type: CharacterInventory
            Protection Level: private

        Name: _name
            Description: Used to hold the name of the character
            Type: string
            Protection Level: private

        Name: Character
            Description: Constructor used to set the characters name to a given value
            Paramater Types: string
            Protection Level: private

        Name: GetName
            Description: Property used to set and get the name of the character
            Type: string
            Protection Level: public

        Name: GetInventory
            Description: Funciton used to return the inventory of the character
            Type: CharacterInventory
            Protection Level: public

        Name: SavePlayer
            Description: Function used to save the inventory of the character
            Type: void
            Parameter Types: string
            Protection Level: public

        Name: LoadPlayer
            Description: Function used to load in character inventory from a previously saved file.
            Type: void
            Parameter Types: string
            Protection Level: public

   **File**: Shop.cs

    Description: Shop is a class used to allow interaction between character and shop keeper.

   **Attributes**

        Name: _merchant
            Description: Used to hold the value of the merchant currently with in this shop.
            Type: ShopKeeper
            Protection Level: private

        Name: _player
            Description: Used to hold the value of the character currently with in this shop
            Type: Character
            Protection Level: private

        Name: Shop
            Description: Constructor used to initialize the instance of thi shop
            Parameter Types: Character, ShopKeeper
            Protection Level: public

        Name: ShopMenu
            Description: Function used to display the base shopping menu.
            Type: void
            Protection Level: public

        Name: BuyingMenu
            Description: Function used to display the the shop keeper inventory and allow the character to select which item they wish to buy
            Type: void
            Protection Level: public

        Name: SellingMenu
            Description: Funciton used to display the character inventory and to allow the character to select which item they wish to sell
            Type: void
            Protection Level: public

        Name: PlayerBuying
            Description: Decrements the gold variable of the player by the value of the item purchased and gives the merchant that amount of gold
            Type: void
            Parameter Types: int
            Protection Level: public

        Name: PlayerSelling
            Description: Decrements the gold variable of the merchant by the value of the item sold and gives that amount of gold to the character
            Type: void
            Parameter Types: int
            Protection Level: public

        Name: UserEditingMenu
            Description: A function used to display the options the user has as a super user
            Type: void
            Protection Level: public

        Name: AddMenu
            Description: Displays to the super user if they want to add an item to the shop inventory or the character inventory
            Type: void
            Protection Level: public

        Name: RemoveMenu
            Description: Displays to the super user if thyey want to add an item to the shop inventory or the character inventory
            Type: void
            Protection Level: public

        Name: ShopAdd
            Description: Function that allows the super user to add items and gold to the shop inventory
            Type: void
            Protection Level: public

        Name: PlayerAdd
            Description: Function that allows the super user to add items and gold to the character inventory
            Type: void
            Protection Level: public

        Name: ShopRemove
            Description: Function that allows the super user to choose an item to remove from the shop inventory
            Type: void
            Protection Level: public

        Name: PlayerRemove
            Description: Function that allows the super user to choose and item to remove from the character inventory
            Type: void
            Protection Level: public

   **File**: Program.cs

    Description: The Main class in which the code begins to run

   **Attributes**

        Name: player
            Description: holds the value of the Character variable
            Type: Character
            Protection Level: private

        Name: merchant
            Description: holds the value of the ShopKeeper vairable
            Type: ShopKeeper
            Protection Level: private

        Name: store
            Description: holds the value of the Shop variable
            Type: Shop
            Protection Level: private