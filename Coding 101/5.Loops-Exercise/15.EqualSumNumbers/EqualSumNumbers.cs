using System;

class EqualSumNumbers
{
    static void Main()
    {
            // Input variables
        int numbersToEnter = int.Parse(Console.ReadLine());
        int number = 0;
        int maxNumber = int.MinValue;
        int result = 0;

        for (int count = 0; count < numbersToEnter; count++)
        {
            number = int.Parse(Console.ReadLine());
            result += number;
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }
        if (result == 2 * maxNumber)
        {
            Console.WriteLine("Yes\nSum = {0}", maxNumber);
        }
        else
        {
            Console.WriteLine("No\nDiff = {0}", Math.Abs(maxNumber - (result - maxNumber)));
        }

    }
}
