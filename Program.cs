// TOP-LEVEL 

Client client1 = new Client();
client1.Name = "Sarah";
client1.Email = "sarah@email.com";

Console.WriteLine("Client added");
Console.WriteLine("Name: " + client1.Name);
Console.WriteLine("Email: " + client1.Email);

// CLASS DEFINITIONS 

class Client
{
    public string Name;
    public string Email;
}


List<string> clients = new List<string>();

while (true)
{
    Console.WriteLine("Enter client name (or type 'exit' to finish):");
    string input = Console.ReadLine();

    if (input == "exit")
    {
        break;
    }
        clients.Add(input);
        Console.WriteLine($"Client added!");
    }

        Console.WriteLine("All clients:"); 
        foreach (string client in clients)
        {
            Console.WriteLine(client);
        }
    class Client
{
    public string Name;
    public string Email;
}  


