using ShoppingLibrary;
using System;
using System.Collections.Generic;

namespace ShoppingCartApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart Cart = new ShoppingCart();

            ShoppingCartItems newItem = new ShoppingCartItems("Xbox", 3950.99);
            Cart.AddShoppingItem(newItem);

            newItem = new ShoppingCartItems("PS4", 5999.49);
            Cart.AddShoppingItem(newItem);

            newItem = new ShoppingCartItems("Nintendo", 7000);
            Cart.AddShoppingItem(newItem);

            List<ShoppingCartItems> items = Cart.GetItems();

            foreach (ShoppingCartItems item in items)
            {
                Console.Write(item.Name);
                Console.WriteLine(": R" + item.Price);
            }
            Console.WriteLine();
            Console.WriteLine("Sub total: R" + Cart.GetSubTotal());
            Console.WriteLine("With VAT :  R"+ Cart.withVAT());
        }
    }
}
