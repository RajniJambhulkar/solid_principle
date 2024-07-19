using System;

// Define the IOrder interface for adding items to the cart
public interface IOrder
{
    void AddToCart();
}

// Define the IOnlineOrder interface for processing online orders
public interface IOnlineOrder
{
    void CCProcess();
}

// Implement OnlineOrder class which supports both adding items to the cart and processing credit card payments
public class OnlineOrder : IOrder, IOnlineOrder
{
    public void AddToCart()
    {
        // Logic to add items to the cart
        Console.WriteLine("Item added to cart in OnlineOrder.");
    }

    public void CCProcess()
    {
        // Logic to process credit card payment
        Console.WriteLine("Processing credit card payment in OnlineOrder.");
    }
}

// Implement OfflineOrder class which supports adding items to the cart but does not process credit card payments
public class OfflineOrder : IOrder
{
    public void AddToCart()
    {
        // Logic to add items to the cart
        Console.WriteLine("Item added to cart in OfflineOrder.");
    }
}


public class Program
{
    public static void Main()
    {
        IOrder onlineOrder = new OnlineOrder();
        onlineOrder.AddToCart();
        
        IOnlineOrder onlinePayment = new OnlineOrder();
        onlinePayment.CCProcess();

        IOrder offlineOrder = new OfflineOrder();
        offlineOrder.AddToCart();

    }
}
