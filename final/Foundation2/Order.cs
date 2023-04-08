using System;

class Order {
    private Customer _thisClient;
    private List<Product> _shoppingCart;

    public Order(Customer client, List<Product> cart) {
        _thisClient = client;
        _shoppingCart = cart;
    }

    public string ProductTotal() {
        //the sum of all product prices, plus a one-time shipping cost
        double productTotal =  0.00;
        foreach(Product item in _shoppingCart) {
            productTotal += item.ProductPrice();
        }
        if(_thisClient.IsInUSA()) {
            productTotal += 5.00;
        } else {
            productTotal += 35.00;
        }
        return "$" + productTotal.ToString("f2");
    }

    public string PackingLabel() {
        string productLabel = "\nPacking Label: \n";
        foreach(Product item in _shoppingCart) {
            productLabel += item.GetName() + " " + item.GetID() + "\n";
        }
        return productLabel;
    }
    public string ShippingLabel() {
        string shippingLabel = "Shipping Label: \n" + _thisClient.GetName() + "\n" + _thisClient.GetAddress() + "\n";
        return shippingLabel;
    }
}