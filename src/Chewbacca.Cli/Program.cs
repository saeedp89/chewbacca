using Chewbacca.Core;
using Chewbacca.Repositories;

//ShowMenu();
//int? userInput = ReadUserInput();

ProcessEntry();

void ProcessEntry(int? entry = null)
{
    var repo = new ServerRepository(new ChewbaccaDbContext());
    IEnumerable<Server> before = repo.GetAll();
    Console.WriteLine("BEFORE");
    before.ToList().ForEach(Console.WriteLine);
    Console.WriteLine("#####################");
    repo.AddEntity(new Server()
    {
        IPAddress = "47.87.165.16",
        Price = 1.5m,
        HostName = "DALZ009",
        IsActive = true,
        NodeName = "Micro-vm",
        RootPassword = "basterdios",
        NextBillingDate = new DateTime(2023, 4, 19)
    });
    IEnumerable<Server> servers = repo.GetAll();
    Console.Out.WriteLine("AFTER");
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