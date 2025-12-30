using System.Collections.Generic;

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
        Console.WriteLine($"Client added!\n");
    }

        Console.WriteLine("All clients:"); 
        foreach (string client in clients)
        {
            Console.WriteLine(client);
        }
    
