using System;

class CenturiesToMinutes
{
    static void Main()
    {
        ulong centuries = ulong.Parse(Console.ReadLine());
        ulong years = centuries * 100;
        ulong days = (ulong)(years * 365.2422); //int.Parse(Console.ReadLine());
        ulong hours = 24 * days; //int.Parse(Console.ReadLine());
        ulong minutes = 60 * hours; //int.Parse(Console.ReadLine)

        Console.WriteLine("{0}", centuries);
        Console.WriteLine("{0}", years);
        Console.WriteLine("{0}", days);
        Console.WriteLine("{0}", hours);
        Console.WriteLine("{0}", minutes);
    }
}
