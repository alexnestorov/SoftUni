using System;

class MinNumber
{
    static void Main()
    {
        // Input variables
        int numbersToEnter = int.Parse(Console.ReadLine());
        int number = 0;
        int minNumber = int.MaxValue;

        // Main Logic
        for (int count = 1; count <= numbersToEnter; count++)
        {
            number = int.Parse(Console.ReadLine());
            if (number < minNumber)
            {
                minNumber = number;
            }
        }
        // Output
        Console.WriteLine(minNumber);
    }
}
