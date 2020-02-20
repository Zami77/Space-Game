using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceGame
{
    class Item
    {
        //To do, create a dictionary of items with associated costs.
        string name = "";
        int price = 0, 
            quantity = 0;

        public int GetPrice()
        {
            return price;
        }

        public int GetQty()
        {
            return quantity;
        }

        public string NameOfItem()
        {
            return name;
        }
        

    }
}
