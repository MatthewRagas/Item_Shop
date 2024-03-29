﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Item_Shop
{
    class ShopKeeper
    {
        private string _name = "store merchant";


        private ShopInventory _shopInventory;

        public ShopKeeper()
        {
            _shopInventory = new ShopInventory();
        }

        public ShopKeeper(ShopInventory newInventory)
        {
            _shopInventory = newInventory;
        }

        //Returns the name of the shop keeper
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
       
        //Returns the shop inventory variable of the shop keeper.
        public ShopInventory GetInventory()
        {                        
                return _shopInventory;                        
        }

        public void SaveMerchant(string path)
        {
            StreamWriter writer = File.CreateText(path);

            writer.WriteLine(GetInventory().InventoryLength);
            writer.WriteLine(GetName);


            for (int i = 0; i < GetInventory().GetItemList.Length; i++)
            {
                writer.WriteLine(GetInventory().GetItemList[i].GetID);


                //If attack item
                if (GetInventory().GetItemList[i].GetID == 1)
                {
                    writer.WriteLine(GetInventory().GetItemList[i].GetName);
                    writer.WriteLine(GetInventory().GetItemList[i].GetAttack);
                }
                //If Defense item
                else if (GetInventory().GetItemList[i].GetID == 2)
                {
                    writer.WriteLine(GetInventory().GetItemList[i].GetName);
                    writer.WriteLine(GetInventory().GetItemList[i].GetDefense);
                }
                //If consumable
                else if (GetInventory().GetItemList[i].GetID == 3)
                {
                    writer.WriteLine(GetInventory().GetItemList[i].GetName);
                    writer.WriteLine(GetInventory().GetItemList[i].GetHealing);
                }
                writer.WriteLine(GetInventory().GetItemList[i].GetValue);
                writer.WriteLine(GetInventory().GetItemList[i].GetDescription);
            }

            writer.WriteLine(GetInventory().Gold);

            writer.Close();
        }

        public void LoadMerchant(string path)
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
                    if (itemID == 1)
                    {
                        AttackItem attackItem = new AttackItem(reader.ReadLine(),//Item Name
                            Convert.ToInt32(reader.ReadLine()),//Item damage
                            Convert.ToInt32(reader.ReadLine()),//Item value
                            itemID,//Item ID
                            reader.ReadLine());//item Description

                        GetInventory().GetItemList[i] = attackItem;
                    }
                    //If Defense item
                    else if (itemID == 2)
                    {
                        DefenseItem defenseItem = new DefenseItem(reader.ReadLine(),//Item Name
                            Convert.ToInt32(reader.ReadLine()),//Item defense
                            Convert.ToInt32(reader.ReadLine()),//Item value
                            itemID,//Item ID
                            reader.ReadLine());//item Description

                        GetInventory().GetItemList[i] = defenseItem;
                    }
                    //If consumable item
                    else if (itemID == 3)
                    {
                        Consumables consumables = new Consumables(reader.ReadLine(),//Item Name
                            Convert.ToInt32(reader.ReadLine()),//Item healing
                            Convert.ToInt32(reader.ReadLine()),//Item value
                            itemID,//Item ID
                            reader.ReadLine());//item Description

                        GetInventory().GetItemList[i] = consumables;
                    }
                }

                GetInventory().Gold = Convert.ToInt32(reader.ReadLine());

                reader.Close();
            }
        }

    }
}
