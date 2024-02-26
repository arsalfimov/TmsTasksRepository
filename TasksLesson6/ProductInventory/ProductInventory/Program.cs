using ProductInventory.Inventory;
using ProductInventory.Utilities;

namespace ProductInventory
{
    public class Program
    {
        static void Main(string[] args)
        {
            FileHandler.CreateAndFillFileIfNotExists(InventoryInitializer.Initialize());

            var inventory = new Inventory.Inventory();
            var inventoryManager = new InventoryManager(inventory);
            inventoryManager.Start();
        }
    }
}
