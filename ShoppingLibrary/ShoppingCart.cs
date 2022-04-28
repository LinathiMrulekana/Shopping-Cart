using System;
using System.Collections.Generic;

namespace ShoppingLibrary
{
    public class ShoppingCart 
    {
        List<ShoppingCartItems> _Items = new List<ShoppingCartItems>();

        public void AddShoppingItem(ShoppingCartItems item)
        {
            _Items.Add(item);
        }

        public List<ShoppingCartItems> GetItems()
        {
            return _Items;
        }

        public double GetSubTotal()
        {
            double total = 0;

            foreach (ShoppingCartItems item in _Items)
            {
                total += item.Price;
            }

            return total;
        }

        public double withVAT()
        {
            double subtotal = GetSubTotal();
            double totalVAT = 0;

            totalVAT = (subtotal * 0.15) + subtotal ;

            return totalVAT;

        }
    }
}
