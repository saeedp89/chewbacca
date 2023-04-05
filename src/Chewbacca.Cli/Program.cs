using Chewbacca.Core;
using Chewbacca.Repositories;

//ShowMenu();
//int? userInput = ReadUserInput();

ProcessEntry();

void ProcessEntry(int? entry = null)
{
    var repo = new ServerRepository();
    IList<Server> servers = repo.GetAllServers();
    servers.ToList().ForEach(Console.WriteLine);
}

int ReadUserInput()
{
    var input = Console.ReadLine();
    return Convert.ToInt32(input);
}

void ShowMenu()
{
    Console.Out.WriteLine("Choose an option: ");
    Console.Out.WriteLine(@"
1) show all Servers
    ");
}