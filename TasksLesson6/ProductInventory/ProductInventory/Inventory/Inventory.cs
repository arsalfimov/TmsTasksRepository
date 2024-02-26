using ProductInventory.Products;
using ProductInventory.Utilities;

namespace ProductInventory.Inventory;
public class Inventory
{
    private List<Product> products;
    private int nextId;

    public Inventory()
    {
        products = FileHandler.FileExists() ? FileHandler.ReadFromFile() : new List<Product>();
        nextId = products.Count > 0 ? products.Max(p => p.Id) + 1 : 1;
    }

    public int GetNextId()
    {
        return nextId++;
    }

    public void AddProduct(string name, double price, int quantity)
    {
        Product newProduct = new Product(GetNextId(), name, price, quantity);
        products.Add(newProduct);
        Console.WriteLine($"The product \"{name}\" has been added to the inventory.");
        FileHandler.WriteToFile(products);
    }

    public void RemoveProductById(int id)
    {
        Product productToRemove = products.FirstOrDefault(p => p.Id == id);
        if (productToRemove != null)
        {
            products.Remove(productToRemove);
            Console.WriteLine($"The product \"{productToRemove.Name}\" removed from inventory.");

            if (id == nextId - 1)
            {
                nextId--;
            }

            FileHandler.WriteToFile(products);
        }
        else
        {
            Console.WriteLine($"Product with {id} ID not found in the inventory.");
        }
    }

    public void ListAllProducts()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("The inventory is empty.");
        }
        else
        {
            Console.WriteLine("List of products in the inventory:");
            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.Id}, Title: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");
            }
        }
    }

    public double GetTotalValue()
    {
        return products.Sum(p => p.Price * p.Quantity);
    }
}
