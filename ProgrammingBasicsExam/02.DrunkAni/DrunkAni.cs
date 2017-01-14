using System;

class DrunkAni
{
    static void Main()
    {
        int numberCabins = int.Parse(Console.ReadLine());
        string stopMessage = Console.ReadLine().ToLower();
        int currentPosition = 0;
        long totalSteps = 0;
        while (stopMessage != "found a free one!")
        {
            int lines = int.Parse(stopMessage);
            int oldPositon = currentPosition;
            currentPosition = (currentPosition + lines) % numberCabins;
            int difference = currentPosition - oldPositon;
            if (difference > 0)
            {
                Console.WriteLine("Go {0} steps to the right, Ani.", Math.Abs(difference));
            }
            else if (difference < 0)
            {
                Console.WriteLine("Go {0} steps to the left, Ani.", Math.Abs(difference));
            }
            else
            {
                Console.WriteLine("Stay there, Ani.");
            }
            stopMessage = Console.ReadLine().ToLower();
            totalSteps += Math.Abs(difference);
        }
        Console.WriteLine("Moved a total of {0} steps.", totalSteps);
    }
}
