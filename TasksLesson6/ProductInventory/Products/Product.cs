namespace ProductInventory.Products;
public class Product
{
    public int Id { get; }
    public string Name { get; }
    public double Price { get; }
    public int Quantity { get; set; }

    public Product(int id, string name, double price, int quantity)
    {
        Id = id;
        Name = name;
        Price = price;
        Quantity = quantity;
    }
}
