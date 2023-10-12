using N10_HT2;
using System;

namespace N10_HT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product { Id = 1, Name = " Olma" };
            Product product2 = new Product { Id = 2, Name = " Go'sht" };
            Product product3 = new Product { Id = 3, Name = " Karam" };

            ShoppingCart library = new ShoppingCart();
            library.Add(product1, 5);
            library.Add(product2, 3);
            library.Add(product3, 2);

            // remove
            int productId = 2; // Olib turgan kitobning Id sini kiritamiz
            bool isSuccessfulCheckout = library.Remove(productId);

            if (isSuccessfulCheckout)
            {
                Console.WriteLine("Maxsulot Korzinkadan olib tashlandi!");
            }
            else
            {
                Console.WriteLine("Unday maxsulot topilmadi!");
            }


        }
    }
}