namespace OnlineOrdering;

public class Product
{
    private string name;
    private int productId;
    private double price;
    private int quantity;

    // Constructor
    public Product(string name, int productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    // Get the total price for this product (price * quantity)
    public double GetTotalPrice()
    {
        return price * quantity;
    }

    // Get product details (name + product ID)
    public string GetProductDetails()
    {
        return $"{name} (ID: {productId})";
    }
}
