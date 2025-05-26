namespace OnlineOrdering;

public class Customer
{
    private string name;
    private Address address;

    // Constructor
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    // Get the customer's name
    public string GetName()
    {
        return name;
    }

    // Check if the customer is in the USA
    public bool IsInUSA()
    {
        return address.IsInUSA();
    }

     public Address GetAddress()
    {
        return address;
    }
}
