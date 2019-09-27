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

3. Output Information
- The program displays many different menus with options for the player to select what to do next:
    - **Name Character**: If the application is starting up for the first time, the user should get a prompt allowing them to name their character.

    - **Shop Menu**: Upon start up or after naming the character, the user is presented with three options to either exit from the application, buy, or sell.

    - **Buying Menu**: Upon selecting the option to buy, the menu changes to display the shop inventory which the user can choose to buy an item from.

    - **Selling Menu**: Upon selecting the option to sell, the menu changes to display the character inventory which the user can choose an item from to sell to the shop.

    - **SUPER USER Menu**: If the user types "SUPER USER" in all caps from the shop menu, they will be displayed two options asking if they want to add/remove an item from the application or exit from the super user menu.

    - **Add Menu**: If the user selects the option to add an item, the application will then display to the user if they want to add to the character inventory, the shop inventory, or if they want to exit instead. Upon selecting either of the two options they are then presented with options to add either an attack item, a defense item, a consumable, gold, or to exit