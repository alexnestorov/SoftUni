using System;

class TriangleOfDollars
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());

        for (int rows = 1; rows <= height; rows++)
        {
        //    Console.Write("$");
            for (int cols = 1; cols <= rows; cols++)
            {
                Console.Write("$ ");
            }
            Console.WriteLine();
        }
    }
}
