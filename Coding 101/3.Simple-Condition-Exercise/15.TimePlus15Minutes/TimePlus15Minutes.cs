using System;

class TimePlus15Minutes
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        int extraMinutes = 15;
        int sumMinutes = minutes + extraMinutes;
        if (sumMinutes >= 60 && hours >= 23)
        {
            Console.WriteLine("0:{0:D2}", sumMinutes - 60);
        }
        else if (sumMinutes >= 60 && hours < 23)
        {
            Console.WriteLine("{0}:{1:D2}", hours + 1, sumMinutes - 60);
        }
        else
        {
            Console.WriteLine("{0}:{1:D2}", hours, sumMinutes);
        }
    }
}
