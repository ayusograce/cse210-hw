public class Product{
    private string _name;
    private int _productId;
    private double _price;
    private double _quantity;

    public Product(string name, int productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = (double)quantity;
    }

    public double TotalProduct()
    {
        return _price*_quantity;
    }

    public string ProductInfo()
    {
        return $"{_name} (ID:{_productId})";
    }
}