using System;

class Greeting
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        sbyte age = sbyte.Parse(Console.ReadLine());

        Console.WriteLine($"Hello, {firstName} {lastName}.\r\nYou are {age} years old.");
    }
}
