namespace Chewbacca.Core;

public class Server
{
    public int Id { get; set; }
    public string IPAddress { get; set; }
    public decimal Price { get; set; }
    public string RootPassword { get; set; }
    public string NodeName { get; set; }
    public string HostName { get; set; }
    public DateTime NextBillingDate { get; set; }
    public bool IsActive { get; set; }
    public override string ToString()
    {
        return $"{Id}\t{IPAddress}";
    }
}