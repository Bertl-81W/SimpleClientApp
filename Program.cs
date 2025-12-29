using System;

List<string> clients = new List<string>();

while (true)
{
    Console.WriteLine("Enter client name to add (or type 'exit' to quit):");
    string input = Console.ReadLine()!;

    if (input.ToLower() == "exit")
    {
        break;
    }

    if (!string.IsNullOrWhiteSpace(input))
    {
        clients.Add(input);
        Console.WriteLine($"Client '{input}' added.");
    }
    else
    {
        Console.WriteLine("Client name cannot be empty.");
    }
}