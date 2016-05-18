using System;

class SumNumbers
{
    static void Main()
    {
        // Input variables
        int numbersToEnter = int.Parse(Console.ReadLine());
        int numbersToSum = 0;
        int result = 0;

        // Main Logic
        for (int count = 1; count <= numbersToEnter; count++)
        {
            numbersToSum = int.Parse(Console.ReadLine());
            result += numbersToSum;
        }
        // Output
        Console.WriteLine(result);
    }
}
