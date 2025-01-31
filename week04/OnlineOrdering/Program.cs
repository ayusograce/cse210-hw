using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello World! This is the OnlineOrdering Project.");

        //FIRST CUSTOMER WITH ADDRESS AND ORDER
        Address address1 = new Address("Melbourne Street", "Beach City", "Oklahoma", "USA");
        Customer customer1 = new Customer("Jhon Beach", address1);
        Order order1 = new Order(customer1);
        Product product1 = new Product("Yellow dress", 2345, 15.50, 1);
        Product product2 = new Product("Socks 4 pack", 5678, 3.99, 2);
        Product product3 = new Product("Black shirt", 7890, 25, 1);

        //SECOND CUSTOMER AND ORDER
        Address address2 = new Address("Strongrock Street", "Montecristi", "Manabí", "Ecuador");
        Customer customer2 = new Customer("Eduardo Mejía", address2);
        Order order2 = new Order(customer2);
        Product product4 = new Product("Black high waisted jeans", 5643, 35.99, 2);
        Product product5 = new Product("Red t-shirt", 3753, 5.5, 3);

        //ADD PRODUCTS TO THE ORDER
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        //DISPLAY THE RESULTS ORDER1
        order1.PackagingLabel();
        order1.ShippingLabel();
        Console.WriteLine($"The total price is: ${order1.TotalPrice()}");

        //DISPLAY THE RESULTS ORDER2
        order2.PackagingLabel();
        order2.ShippingLabel();
        Console.WriteLine($"The total price is: ${order2.TotalPrice()}\n");

        
        



    }
}