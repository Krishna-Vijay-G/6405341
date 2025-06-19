using System;
using System.Linq;

namespace Ecommerce
{
    public class SearchAlgorithms
    {
        public static Product? LinearSearch(Product[] products, string name)
        {
            foreach (Product product in products)
            {
                if (product.ProductName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return product;
                }
            }
            return null;
        }

        public static Product? BinarySearch(Product[] products, string name)
        {
            var sorted = products.OrderBy(p => p.ProductName.ToLower()).ToArray();
            int left = 0, right = sorted.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int cmp = string.Compare(name, sorted[mid].ProductName, StringComparison.OrdinalIgnoreCase);

                if (cmp == 0)
                    return sorted[mid];
                else if (cmp < 0)
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return null;
        }
    }
}
