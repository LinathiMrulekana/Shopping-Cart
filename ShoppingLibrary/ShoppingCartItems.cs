using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    public class ShoppingCartItems 
    {
        protected string _name;
        protected double _price;

        public string Name { get { return _name; } }
        public double Price { get { return _price; } }

        public ShoppingCartItems(string name, double price)
        {
            _name = name;
            _price = price; 
        }

    }
}
