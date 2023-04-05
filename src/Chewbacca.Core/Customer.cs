namespace Chewbacca.Core;

public class Customer
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public Server Server { get; set; }
    public Subscription Subscription { get; set; }
}


public class Subscription
{
    public SubscriptionType SubscriptionType { get; set; }
    public int Month { get; set; }
    public int ConcurrentConnections { get; set; }
    public decimal Price { get; set; }
    
}

public class SubscriptionType
{
    public int Months { get; set; }
    public int ConcurrentConnection { get; set; }
    public decimal Price { get; set; }
}
