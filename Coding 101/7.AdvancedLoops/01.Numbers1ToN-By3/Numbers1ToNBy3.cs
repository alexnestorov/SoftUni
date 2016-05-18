using System;

class Numbers1ToNBy3
{
    static void Main()
    {
        int lastNumber = int.Parse(Console.ReadLine());

        for (int count = 1; count <= lastNumber; count += 3)
        {
            Console.WriteLine(count);
        }
    }
}
