namespace OnlineOrdering;

public class Order
{
    private List<Product> products;
    private Customer customer;

    // Constructor
    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    // Get the total price for the order
    public double GetTotalPrice()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.GetTotalPrice();
        }

        // Adding shipping cost based on customer location
        double shippingCost = customer.IsInUSA() ? 5 : 35;
        total += shippingCost;

        return total;
    }

    // Get packing label
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += product.GetProductDetails() + "\n";
        }
        return label;
    }

    // Get shipping label
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
    }
}

