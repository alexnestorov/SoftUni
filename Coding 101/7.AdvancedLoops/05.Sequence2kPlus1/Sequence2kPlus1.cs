using System;

class Sequence2kPlus1
{
    static void Main()
    {
        int lastNumber = int.Parse(Console.ReadLine());
        int printNumber = 0;

        for (int count = 1; count <= lastNumber; count = 2 * printNumber + 1)
        {
            printNumber = count;
            Console.WriteLine(printNumber);
        }
    }
}
