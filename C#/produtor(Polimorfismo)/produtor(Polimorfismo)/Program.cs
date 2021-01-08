using System;
using System.Globalization;
using System.Collections.Generic;
using produtor_Polimorfismo_.Entities;

namespace produtor_Polimorfismo_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported? (c/u/i) ");
                char productType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (productType == 'u')
                {
                    Console.Write("Manufacture date (dd/mm/yyyy): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    UsedProduct product = new UsedProduct(name, price, manufactureDate);
                    products.Add(product);
                }
                else if (productType == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    ImportedProduct product = new ImportedProduct(name, price, customsFee);
                    products.Add(product);
                }
                else
                {
                    Product product = new Product(name, price);
                    products.Add(product);
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product p in products)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}
