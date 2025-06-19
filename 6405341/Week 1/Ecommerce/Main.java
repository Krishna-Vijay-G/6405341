package Ecommerce;

public class Main {
    public static void main(String[] args) {
        Product[] products = {
            new Product(101, "Laptop", "Electronics"),
            new Product(102, "Shirt", "Clothing"),
            new Product(103, "Book", "Books"),
            new Product(104, "Smartphone", "Electronics"),
            new Product(105, "Shoes", "Footwear")
        };

        String searchTerm = "Smartphone";

        System.out.println("Linear Search:");
        Product result1 = SearchAlgorithms.linearSearch(products, searchTerm);
        System.out.println(result1 != null ? result1 : "Product not found.");

        System.out.println("\nBinary Search:");
        Product result2 = SearchAlgorithms.binarySearch(products, searchTerm);
        System.out.println(result2 != null ? result2 : "Product not found.");

        System.out.println("\nDone by Superset ID: 6405341\n");
    }
}
