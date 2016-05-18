using System;

class NumbersNTo1
{
    static void Main()
    {
        int finalNumber = int.Parse(Console.ReadLine());

        for (int count = finalNumber; count >= 1; --count)
        {
            Console.WriteLine(count);
        }
    }
}
