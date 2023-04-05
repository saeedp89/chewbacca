using Chewbacca.Core;
using MySql.Data.MySqlClient;

namespace Chewbacca.Repositories;

public class ServerRepository : IServerRepository
{
    private readonly ChewbaccaDbContext _context;

    public ServerRepository()
    {
        _context = new ChewbaccaDbContext();
    }

    public IList<Server> GetAllServers()
    {
        var servers = new List<Server>();
        using var conn = _context.GetConnection();
        conn.Open();
        var command = new MySqlCommand("SELECT * FROM servers", conn);
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            servers.Add(new Server()
            {
                Id = reader.GetInt32("Id"),
                IPAddress = reader.GetString("IPAddress"),
                Price = reader.GetDecimal("Price"),
                HostName = reader.GetString("HostName"),
                IsActive = reader.GetBoolean("IsActive"),
                NodeName = reader.GetString("NodeName"),
                RootPassword = reader.GetString("RootPassword"),
                NextBillingDate = reader.GetDateTime("NextBillingDate")
            });
        }

        return servers;
    }

    public Server AddServer(Server server)
    {
        return server;
    }
}