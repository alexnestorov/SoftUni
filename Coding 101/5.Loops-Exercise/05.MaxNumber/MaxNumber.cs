using System;

class MaxNumber
{
    static void Main()
    {
        // Input variables
        int numbersToEnter = int.Parse(Console.ReadLine());
        int number = 0;
        int maxNumber = int.MinValue;

        // Main Logic
        for (int count = 1; count <= numbersToEnter; count++)
        {
            number = int.Parse(Console.ReadLine());
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }
        // Output
        Console.WriteLine(maxNumber);
    }
}
