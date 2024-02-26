using ProductInventory.Products;

namespace ProductInventory.Utilities;

public static class InventoryInitializer
{
    public static List<Product> Initialize()
    {
        List<Product> initialProducts = new List<Product>
            {
                new Product(1, "Monitor", 150.25, 5),
                new Product(2, "Keyboard", 29, 10),
                new Product(3, "Mouse", 19, 15),
                new Product(4, "Laptop", 999.50, 3),
                new Product(5, "Headphones", 49.25, 20),
            };
        return initialProducts;
    }
}