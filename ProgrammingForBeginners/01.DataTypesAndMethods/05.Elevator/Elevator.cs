using System;

class Elevator
{
    static void Main()
    {
        int person = int.Parse(Console.ReadLine());
        int capacity = int.Parse(Console.ReadLine());

        double result = Math.Ceiling((double)person / capacity);
        Console.WriteLine(result);
    }
}
