
class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double CalculateTotalPrice()
    {
        double totalPrice = 0;

        foreach (Product product in products)
        {
            totalPrice += product.CalculatePrice();
        }

        if (customer.IsInUSA())
        {
            totalPrice += 5; // USA shipping cost
        }
        else
        {
            totalPrice += 35; // International shipping cost
        }

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = $"Packing Label for {customer.GetName()}:\n";

        foreach (Product product in products)
        {
            packingLabel += $"- {product.GetName()}, ID: {product.GetProductId()}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"Shipping Label for {customer.GetName()}:\n";
        shippingLabel += customer.GetAddress().GetFullAddress();

        return shippingLabel;
    }
}
