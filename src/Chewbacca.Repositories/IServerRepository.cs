using Chewbacca.Core;

namespace Chewbacca.Repositories;

public interface IServerRepository
{
    IEnumerable<Server> GetAll();
    void AddEntity(Server server);
    void EditEntity(Server server);
    void DeleteEntity(int id);
    Server GetEntity(int id);
}