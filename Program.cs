// Top level code

List<Client> clients = new List<Client>();

while (true)
{
    Console.WriteLine("Enter client name (or type 'exit' to finish):");
    string name = Console.ReadLine();

    if (name == "exit")
    {
        break;
    }

    Console.WriteLine("Enter client email:");
    string email = Console.ReadLine();

    Client newClient = new Client();
    newClient.Name = name;
    newClient.Email = email;

    clients.Add(newClient);

    Console.WriteLine("Client added!\n");
}

Console.WriteLine("All clients:");
foreach (Client client in clients)
{
    Console.WriteLine(client.Name + " - " + client.Email);
}

// class defionitions come last
class Client
{
    public string Name;
    public string Email;
}