using System;

class Fibonacci
{
    static void Main()
    {
        int sequence = int.Parse(Console.ReadLine());
        int fibonacciFirst = 1;
        int fibonacciSecond = 1;
        for (int count = 1; count <= sequence; count++)
        {
            int fibonacciThird = fibonacciFirst + fibonacciSecond;
            fibonacciFirst = fibonacciSecond;
            fibonacciSecond = fibonacciThird;
        }
        Console.WriteLine(fibonacciSecond);
    }
}
