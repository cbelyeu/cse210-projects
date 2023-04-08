using System;

class Program
{
    static void Main(string[] args)
    {
        Address harryAddress = new Address("4 Privet Drive","Little Whinging","Surrey","England");
        Customer client1 = new Customer("Harry Potter", harryAddress);
        List<Product> harryList = new List<Product>() {
            new Product("plain work robes(black)",1234,12.50,3),
            new Product("cauldron(pewter,standard size 2)",5678,50.20,1),
            new Product("plain pointed hat(black)",9101,6.03,1),
            new Product("winter cloak(black,silver fastenings)",1112,20.50,1)
        };
        Order o1 = new Order(client1,harryList);
        Console.WriteLine(o1.PackingLabel());
        Console.WriteLine(o1.ShippingLabel());
        Console.WriteLine("Price: " + o1.ProductTotal());

        Address sherlockAddress = new Address("221b Baker Street","London","NW1 6XE","UK");
        Customer client2 = new Customer("Sherlock Holmes",sherlockAddress);
        List<Product> sherlockList = new List<Product>() {
            new Product("ethernet cables",1314,3.75,2),
            new Product("biscuits",1516,5.52,7)
        };
        Order o2 = new Order(client2,sherlockList);
        Console.WriteLine(o2.PackingLabel());
        Console.WriteLine(o2.ShippingLabel());
        Console.WriteLine("Price: " + o2.ProductTotal() + "\n");
    }
}