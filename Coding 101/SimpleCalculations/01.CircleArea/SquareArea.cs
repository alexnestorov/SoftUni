using System;


class SquareArea
{
    static void Main()
    {
        Console.Write("a=");
        var a = int.Parse(Console.ReadLine());
        var area = a * a;
        Console.Write("Square a=");
        Console.WriteLine("{0}",area);
    }
}

