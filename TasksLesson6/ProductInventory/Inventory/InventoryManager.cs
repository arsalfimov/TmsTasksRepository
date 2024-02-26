namespace ProductInventory.Inventory;
public class InventoryManager
{
    private Inventory inventory;

    public InventoryManager(Inventory inventory)
    {
        this.inventory = inventory;
    }

    public void Start()
    {
        while (true)
        {
            DisplayMenu();
            string choice = Console.ReadLine();
            HandleChoice(choice);
        }
    }

    private void DisplayMenu()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\nSelect an action:");
        Console.WriteLine("1. Add a product");
        Console.WriteLine("2. To delete a product by ID");
        Console.WriteLine("3. Display a list of all products");
        Console.WriteLine("4. Get the sum of all products");
        Console.WriteLine("5. Exit\n");
        Console.ResetColor();
    }

    private void HandleChoice(string choice)
    {
        switch (choice)
        {
            case "1":
                AddProduct();
                break;
            case "2":
                RemoveProduct();
                break;
            case "3":
                ListAllProducts();
                break;
            case "4":
                GetTotalValue();
                break;
            case "5":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Incorrect choice of action.");
                break;
        }
    }

    private void AddProduct()
    {
        Console.Write("\nEnter the product name: ");
        string name = Console.ReadLine();
        double price = GetValidDoubleInput("Enter the product price: ");
        int quantity = GetValidIntInput("Enter the product quantity: ");
        inventory.AddProduct(name, price, quantity);
    }

    private void RemoveProduct()
    {
        int id = GetValidIntInput("\nEnter the product ID: ");
        inventory.RemoveProductById(id);
    }

    private void ListAllProducts()
    {
        inventory.ListAllProducts();
    }

    private void GetTotalValue()
    {
        Console.WriteLine($"\nThe total cost of all products in the inventory: {inventory.GetTotalValue()}$");
    }

    private double GetValidDoubleInput(string message)
    {
        double result;
        while (true)
        {
            Console.Write(message);
            if (double.TryParse(Console.ReadLine(), out result) && result > 0)
            {
                return result;
            }
            else
            {
                Console.WriteLine("Incorrect input. Try again.");
            }
        }
    }

    private int GetValidIntInput(string message)
    {
        int result;
        while (true)
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out result) && result > 0)
            {
                return result;
            }
            else
            {
                Console.WriteLine("Incorrect input. Try again.");
            }
        }
    }
}
