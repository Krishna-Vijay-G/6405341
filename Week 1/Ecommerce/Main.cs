using System;

namespace Ecommerce
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Product[] products = {
                new Product(101, "Laptop", "Electronics"),
                new Product(102, "Shirt", "Clothing"),
                new Product(103, "Book", "Books"),
                new Product(104, "Smartphone", "Electronics"),
                new Product(105, "Shoes", "Footwear")
            };

            string searchTerm = "Smartphone";

            Console.WriteLine("Linear Search:");
            Product result1 = SearchAlgorithms.LinearSearch(products, searchTerm);
            Console.WriteLine(result1 != null ? result1.ToString() : "Product not found.");

            Console.WriteLine("\nBinary Search:");
            Product result2 = SearchAlgorithms.BinarySearch(products, searchTerm);
            Console.WriteLine(result2 != null ? result2.ToString() : "Product not found.");

            Console.WriteLine("\nDone by Superset ID: 6405341\n");
        }
    }
}
