using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Item_Shop
{
    class Character
    {
        private CharacterInventory _bag = new CharacterInventory();
        
        private string _name;

        //Constructor for characters that passes in a string for a name
        public Character(string name)
        {
            _name = name;
        }

        //Returns the name variable of the character
        public string GetName
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }            
        }       

        //Returns the Character Inventory variable of the character
        public CharacterInventory GetInventory()
        {
            return _bag;
        }

        public void SavePlayer(string path)
        {            
            StreamWriter writer = File.CreateText(path);

            writer.WriteLine(GetInventory().InventoryLength);
            writer.WriteLine(GetName);
            

            for (int i = 0; i < GetInventory().GetItemList().Length; i++)
            {
                writer.WriteLine(GetInventory().GetItemList()[i].GetID);
                

                //If attack item
                if (GetInventory().GetItemList()[i].GetID == 1)
                {
                    writer.WriteLine(GetInventory().GetItemList()[i].GetName);
                    writer.WriteLine(GetInventory().GetItemList()[i].GetAttack);
                }
                //If Defense item
                else if (GetInventory().GetItemList()[i].GetID == 2)
                {
                    writer.WriteLine(GetInventory().GetItemList()[i].GetName);
                    writer.WriteLine(GetInventory().GetItemList()[i].GetDefense);
                }
                //If consumable
                else if (GetInventory().GetItemList()[i].GetID == 3)
                {
                    writer.WriteLine(GetInventory().GetItemList()[i].GetName);
                    writer.WriteLine(GetInventory().GetItemList()[i].GetHealing);
                }
                writer.WriteLine(GetInventory().GetItemList()[i].GetValue);
                writer.WriteLine(GetInventory().GetItemList()[i].GetDescription);
            }

            writer.Close();
        }

        public void LoadPlayer(string path)
        {
            if (File.Exists(path))
            {
                StreamReader reader = File.OpenText(path);                

                GetInventory().InventoryLength = Convert.ToInt32(reader.ReadLine());

                GetName = reader.ReadLine();

                Item[] newList = new Item[GetInventory().InventoryLength];

                int itemID;

                for (int i = 0; i < GetInventory().InventoryLength; i++)
                {
                    itemID = Convert.ToInt32(reader.ReadLine());

                    //If Attack item
                    if(itemID == 1)
                    {
                        AttackItem attackItem = new AttackItem(reader.ReadLine(),//Item Name
                            Convert.ToInt32(reader.ReadLine()),//Item damage
                            Convert.ToInt32(reader.ReadLine()),//Item value
                            itemID,//Item ID
                            reader.ReadLine());//item Description
                    }
                    //If Defense item
                    else if(itemID == 2)
                    {
                        DefenseItem defenseItem = new DefenseItem(reader.ReadLine(),//Item Name
                            Convert.ToInt32(reader.ReadLine()),//Item defense
                            Convert.ToInt32(reader.ReadLine()),//Item value
                            itemID,//Item ID
                            reader.ReadLine());//item Description                        
                    }
                    //If consumable item
                    else if(itemID == 3)
                    {
                        Consumables consumables = new Consumables(reader.ReadLine(),//Item Name
                            Convert.ToInt32(reader.ReadLine()),//Item healing
                            Convert.ToInt32(reader.ReadLine()),//Item value
                            itemID,//Item ID
                            reader.ReadLine());//item Description                        
                    }
                }
            }
        }
    }
}
