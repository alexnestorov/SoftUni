using System;
using System.Collections.Generic;

class ConvertMeasures
{
    static void Main()
    {
        double measure = double.Parse(Console.ReadLine());
        string firstMeasure = Console.ReadLine();
        string secondMeasure = Console.ReadLine();
        var convert = new Dictionary<string, double> // Why using var???
        {
            {"m",1.0 },
            {"mm",1000.0 },
            {"km",0.001 },
            {"mi",0.000621371192 },
            {"yd",1.0936133 },
            {"ft",3.2808399 },
            {"in",39.3700787 },
            {"cm",100.0 }
        };
        double result = (measure / convert[firstMeasure] * convert[secondMeasure]);
        Console.WriteLine(result);
        
    }
}
