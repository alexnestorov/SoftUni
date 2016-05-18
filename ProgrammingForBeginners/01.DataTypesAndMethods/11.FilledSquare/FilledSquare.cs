using System;

class FilledSquare
{
    static void Main() // Main Method. Print the figure.
    {
        int n = int.Parse(Console.ReadLine());
        TopBottomWall(n);
        MiddlePart(n);
        TopBottomWall(n);
    }
    static void TopBottomWall (int n) // Method for printing top and bottom wall of the figure
    {
        Console.WriteLine(new string('-', 2 * n));
    }
    static void MiddlePart(int n) // Method for printing the middle part of the figure
    {
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write("-",1);
            for (int j = 0; j < n - 1; j++)
            {
                Console.Write("\\/", 2 * n - 2);
            }
            Console.Write("-", 1);
            Console.WriteLine();
        }
    }
}
