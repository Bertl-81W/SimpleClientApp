// Top level code

 /*List<Client> clients = new List<Client>();                        

while (true)                                                      
{                                                                 
    Console.WriteLine("\nChoose an option:");                           
    Console.WriteLine("1, Add a client");                             
    Console.WriteLine("2, List clients");                             
    Console.WriteLine("3, Exit");                                     

    string choice = Console.ReadLine();                                 

    if (choice == "1")                                                  
    {                                                                   
        AddClient(clients);                                                      
    }                                                                 

    else if (choice == "2")                                           
    {                                                                 
        ListClients(clients);                                             
    }                                                                 

    else if (choice == "3")                                           
    {                                                                
        Console.WriteLine("Later Gator!");                             
        break;                                                         
    }                                                                 
    else                                                            
    {                                                                  
        Console.WriteLine("Invalid option. Please choose between 1, 2, or 3.");
    }
    
}
void AddClient(List<Client> clients)
{
    Console.WriteLine("Enter client name:");
    string name = Console.ReadLine();

    Console.WriteLine("Enter client email:");
    string email = Console.ReadLine();

    Client newClient = new Client();
    newClient.Name = name;
    newClient.Email = email;

    clients.Add(newClient);

    Console.WriteLine("Client added!");
}

void ListClients(List<Client> clients)
{
    Console.WriteLine("\nClients:");

    if (clients.Count == 0)
    {
        Console.WriteLine("No clients yet.");
        return;
    }

    foreach (Client client in clients)
    {
        Console.WriteLine(client.Name + " - " + client.Email);
    }
}

//  classes

  class Client
{
    public string Name;
    public string Email;
} */

using System;
using System.Collections.Generic;


List<Joe> joes = new List<Joe>();
 while (true)
 {
     Console.WriteLine("\nChoose an option:");
     Console.WriteLine("1, Add a joe");
     Console.WriteLine("2, List joes");
     Console.WriteLine("3, Exit");

     string choice = Console.ReadLine();

     if (choice == "1")
     {
         AddJoe(joes);
     }

     else if (choice == "2")
     {
         ListJoes(joes);
     }

     else if (choice == "3")
     {
         Console.WriteLine("Yo Joe!");
         break;
     }
     else
     {
         Console.WriteLine("Invalid option. Please choose between 1, 2, or 3.");
     }
 }
 void AddJoe(List<Joe> joes)
{
    Console.WriteLine("Enter Joe name:");
    string name = Console.ReadLine();

    Console.WriteLine("Enter joes specialty:");
    string specialty = Console.ReadLine();

    Joe newJoe = new Joe(name, specialty);
    
    joes.Add(newJoe);

    Console.WriteLine("Joe added!");
}

void ListJoes(List<Joe> joes)
{
    Console.WriteLine("\nJoes:");

    if (joes.Count == 0)
    {
        Console.WriteLine("No joes yet.");
        return;
    }

    foreach (Joe joe in joes)
    {
        Console.WriteLine(joe.Name + " - " + joe.Specialty);
    }
}

//  classes

  class Joe
{
    public string Name { get; }
    public string Specialty { get; }
    
    public Joe(string name, string specialty)
    {
        Name = name;
        Specialty = specialty;
    }
}