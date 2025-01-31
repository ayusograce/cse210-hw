public class Order{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalOrder()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total = total + product.TotalProduct();
        }
        return total;
    }

    public void PackagingLabel()
    {
        Console.WriteLine("------------------------------\n");
        Console.WriteLine("Products:");
        foreach(Product product in _products)
        {
            Console.WriteLine(product.ProductInfo());
        }
    }

    public void ShippingLabel()
    {
        Console.WriteLine("\nShipping:");
        Console.WriteLine($"Name: {_customer.GetFullName()}\nAddress: {_customer.GetFinalAddress()}");
    }

    public double TotalPrice()
    {
        double price = 0;
        if(_customer.LiveInUSA() == true)
        {
            price = TotalOrder() + 5;
        }

        else
        {
            price = TotalOrder() + 35;
        }

        return Math.Round(price,2);
    }
}