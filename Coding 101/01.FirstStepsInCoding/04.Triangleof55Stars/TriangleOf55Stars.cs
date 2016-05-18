using System;

class TriangleOf55Stars
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            string asterisks = new string('*', i);
            Console.WriteLine(asterisks);
        }
    }
}
