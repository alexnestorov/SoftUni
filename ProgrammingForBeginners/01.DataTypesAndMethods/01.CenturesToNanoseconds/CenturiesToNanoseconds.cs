using System;

class CenturiesToNanoseconds
{
    static void Main()
    {
        ulong centuries = ulong.Parse(Console.ReadLine());
        ulong years = centuries * 100;
        ulong days = (ulong)(years * 365.2422); 
        ulong hours = 24 * days; 
        ulong minutes = 60 * hours;
        ulong seconds = 60 * minutes;
        ulong miliseconds = 1000 * seconds;
        ulong microseconds = 1000 * miliseconds;
        decimal nanoseconds = (1000m * microseconds);

        Console.WriteLine("{0}", centuries);
        Console.WriteLine("{0}", years);
        Console.WriteLine("{0}", days);
        Console.WriteLine("{0}", hours);
        Console.WriteLine("{0}", minutes);
        Console.WriteLine("{0}", seconds);
        Console.WriteLine("{0}", miliseconds);
        Console.WriteLine("{0}", microseconds);
        Console.WriteLine("{0}", nanoseconds);
    }
}
