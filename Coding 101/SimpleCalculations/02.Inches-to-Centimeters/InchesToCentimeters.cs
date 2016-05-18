using System;


class InchesToCentimeters
{
    static void Main()
    {
        Console.Write("inch = ");
        var inch = double.Parse(Console.ReadLine());
        var cm = inch * 2.54;
        Console.Write("centimetres = ");
        Console.WriteLine("{0}", cm);
    }
}

