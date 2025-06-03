class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public bool IsInGHA()
    {
        return address.IsInGHA();
    }

    public string GetShippingLabel()
    {
        return $"{name}\n{address.GetFullAddress()}";
    }
}