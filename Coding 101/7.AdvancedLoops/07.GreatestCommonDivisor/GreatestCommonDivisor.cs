using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        while (b != 0)
        {
            int gcd = b;
            b = a % b;
            a = gcd;
        }
        Console.WriteLine("Greatest common divider is: {0}", a);
    }
}
