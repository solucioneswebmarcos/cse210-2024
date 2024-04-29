using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what is your first name?");
        string FirstName = Console.ReadLine();

        Console.WriteLine("what is your last name?");
        string LastName = Console.ReadLine();

        Console.WriteLine($"My name is {LastName} {LastName}, {FirstName}");
    }
}