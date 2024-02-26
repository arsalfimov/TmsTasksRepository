using Newtonsoft.Json;
using ProductInventory.Products;

namespace ProductInventory.Utilities;

public class FileHandler
{
    private static readonly string filePath = "ProductInventoryDb.json";

    public static void CreateAndFillFileIfNotExists(List<Product> initialData)
    {
        if (!FileExists())
        {
            WriteToFile(initialData);
        }
    }

    public static bool FileExists()
    {
        return File.Exists(filePath);
    }

    public static List<Product> ReadFromFile()
    {
        try
        {
            string jsonData = File.ReadAllText(filePath);
            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(jsonData);
            return products ?? new List<Product>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading the file: {ex.Message}");
            return new List<Product>();
        }
    }

    public static void WriteToFile(List<Product> products)
    {
        try
        {
            string jsonData = JsonConvert.SerializeObject(products);
            File.WriteAllText(filePath, jsonData);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error writing the file: {ex.Message}");
        }
    }
}
