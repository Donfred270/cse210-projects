namespace OnlineOrdering;
public class Address
{
    private string streetAddress;
    private string city;
    private string state;
    private string country;

    // Constructor
    public Address(string streetAddress, string city, string state, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    // Check if the address is in the USA
    public bool IsInUSA()
    {
        return country.ToLower() == "usa";
    }

    // Get the full address
    public string GetFullAddress()
    {
        return $"{streetAddress}\n{city}, {state}\n{country}";
    }

}
