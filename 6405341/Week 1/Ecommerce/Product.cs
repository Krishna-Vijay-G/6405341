namespace Ecommerce
{
    public class Product
    {
        public int ProductId;
        public string ProductName;
        public string Category;

        public Product(int id, string name, string cat)
        {
            ProductId = id;
            ProductName = name;
            Category = cat;
        }

        public override string ToString()
        {
            return $"{ProductId} - {ProductName} ({Category})";
        }
    }
}
