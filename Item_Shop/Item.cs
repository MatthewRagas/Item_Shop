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
        public virtual string GetName()
        {
            return _name;
        }

        //Function to return item gold value
        public virtual int GetValue()
        {
            return _value;
        }

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

        public string GetDescription()
        {
            return _description;
        }
    }
}
