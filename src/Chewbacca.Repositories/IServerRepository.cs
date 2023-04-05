using Chewbacca.Core;

namespace Chewbacca.Repositories;

public interface IServerRepository
{
    IList<Server> GetAllServers();
}