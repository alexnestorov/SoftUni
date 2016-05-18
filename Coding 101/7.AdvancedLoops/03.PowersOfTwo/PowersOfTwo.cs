using System;

class PowersOfTwo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int printNumber = 1;

        for (int count = 0; count <= n; count++)
        {
            printNumber = (int) Math.Pow(2, count);
            Console.WriteLine(printNumber);
        }
    }
}
