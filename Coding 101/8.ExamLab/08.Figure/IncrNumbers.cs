using System;

class IncrNumbers
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());
        int counter = 0;
        int maxCounter = 0;
        int maxNum = int.MinValue;
        for (int i = 0; i < numbers; i++)
        {
            int input = int.Parse(Console.ReadLine());
            if (input > maxNum)
            {
                counter++;
            }
            else
            {
                counter = 1;
            }
            if (counter > maxCounter)
            {
                maxCounter = counter;
            }
            maxNum = input;
        }
        Console.WriteLine(maxCounter);
    }
}
