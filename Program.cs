using System;
using System.Collections.Generic;

class Contact
{
    public string Name { get; set; }
    public string Number { get; set; }
}

class Program
{
    static List<Contact> contacts = new List<Contact>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter a command (add, show1, show2, exit):");
            string command = Console.ReadLine();

            if (command == "add")
            {
                AddContact();
            }
            else if (command == "show1")
            {
                ShowContactsByName();
            }
            else if (command == "show2")
            {
                ShowContactsByNumber();
            }
            else if (command == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid command.");
            }
        }
    }

    static void AddContact()
    {
        Console.WriteLine("Enter the contact name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the contact number:");
        string number = Console.ReadLine();

        contacts.Add(new Contact { Name = name, Number = number });

        Console.WriteLine("Contact added.");
    }

    static void ShowContactsByName()
    {
        Console.WriteLine("Enter the contact name:");
        string name = Console.ReadLine();

        foreach (var contact in contacts)
        {
            if (contact.Name == name)
            {
                Console.WriteLine("{0}: {1}", contact.Name, contact.Number);
            }
        }
    }

    static void ShowContactsByNumber()
    {
        Console.WriteLine("Enter the contact number:");
        string number = Console.ReadLine();

        foreach (var contact in contacts)
        {
            if (contact.Number == number)
            {
                Console.WriteLine("{0}: {1}", contact.Number, contact.Name);
            }
        }
    }
}
