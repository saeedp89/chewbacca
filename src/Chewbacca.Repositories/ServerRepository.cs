using System.Text;
using Chewbacca.Core;
using MySql.Data.MySqlClient;

namespace Chewbacca.Repositories;

public class ServerRepository : IServerRepository
{
    private readonly ChewbaccaDbContext _context;

    public ServerRepository(ChewbaccaDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Server> GetAll()
    {
        using var conn = _context.GetConnection();
        conn.Open();
        var command = new MySqlCommand("SELECT * FROM servers", conn);
        using var reader = command.ExecuteReader();
        while (reader.Read())
            yield return new Server()
            {
                Id = reader.GetInt32(nameof(Server.Id)),
                IPAddress = reader.GetString(nameof(Server.IPAddress)),
                Price = reader.GetDecimal(nameof(Server.Price)),
                HostName = reader.GetString(nameof(Server.HostName)),
                IsActive = reader.GetBoolean(nameof(Server.IsActive)),
                NodeName = reader.GetString(nameof(Server.NodeName)),
                RootPassword = reader.GetString(nameof(Server.RootPassword)),
                NextBillingDate = reader.GetDateTime(nameof(Server.NextBillingDate))
            };
    }

    public void AddEntity(Server server)
    {
        var command = new MySqlCommand();
        using var conn = _context.GetConnection();
        conn.Open();
        command.Connection = conn;
        command.CommandText =
            $"INSERT INTO servers(IPAddress,Price,HostName,NodeName,RootPassword,NextBillingDate) VALUES ('{server.IPAddress}',{server.Price},'{server.HostName}','{server.NodeName}','{server.RootPassword}','2023-04-23')";
        command.ExecuteNonQuery();
    }

    public void EditEntity(Server server)
    {
        var savedEntity = GetEntity(server.Id);
        var command = new StringBuilder("UPDATE servers SET");
        if(savedEntity.IPAddress!=server.IPAddress)
            command.Append("")
            
    }

    public void DeleteEntity(int id)
    {
        throw new NotImplementedException();
    }

    public Server GetEntity(int id)
    {
        throw new NotImplementedException();
    }
}