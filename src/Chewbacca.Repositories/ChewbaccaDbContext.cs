using Chewbacca.Core;
using MySql.Data.MySqlClient;

namespace Chewbacca.Repositories;

public class ChewbaccaDbContext 
{
    public string ConnectionString => "server=127.0.0.1;port=3306;database=vortexvpn;user=saeed;password=basterdios";

    public MySqlConnection GetConnection()
        => new(ConnectionString);
}
