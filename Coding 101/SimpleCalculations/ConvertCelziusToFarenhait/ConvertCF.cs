using System;

class ConvertCF
{
    static void Main()
    {
        var celzius = double.Parse(Console.ReadLine());
        //var farenheit = Math.Round(1.8 * celzius + 32, 2);
        Console.WriteLine(Math.Round(1.8 * celzius + 32, 2));
    }
}
