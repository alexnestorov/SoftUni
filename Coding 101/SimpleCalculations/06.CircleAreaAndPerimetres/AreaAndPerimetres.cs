using System;

class AreaAndPerimetres
{
    static void Main()
    {
        var r = double.Parse(Console.ReadLine());
        var area = Math.PI * r * r;
        var perimetres = 2 * Math.PI * r;
        Console.WriteLine("Area: {0}\nPerimetres: {1}",area, perimetres);
    }
}
