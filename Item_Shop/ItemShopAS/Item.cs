using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item_Shop
{
    class Item
    {

        //Gold variable
        protected int _value = 1;

        //Name variable
        protected string _name = "";                

        protected string _description;
        //Function to return item name
        public virtual string GetName
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

        //Function to return item gold value
        public virtual int GetValue
        {
            set
            {
                _value = value;
            }
            get
            {
                return _value;
            }            
        }

        //Property to set and get the damage of attack items
        public virtual int GetAttack
        {
            set
            {

            }
            get
            {
                return 0;
            }            
        }

        //Property to get the defense of defense items
        public virtual int GetDefense
        {
            set
            {

            }
            get
            {
                return 0;
            }            
        }

        //Property to get the healing of consumable items
        public virtual int GetHealing
        {
            set
            {

            }
            get
            {
                return 0;
            }            
        }
        
        //Property to et the description of items
        public string GetDescription
        {
            set
            {
                _description = value;
            }
            get
            {
                return _description;
            }            
        }

        //Property to get the item id
        public virtual int GetID
        {
            set
            {

            }
            get
            {
                return 0;
            }
        }
    }
}
