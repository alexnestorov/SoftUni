using System;

class DateAfter5Days
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        day = day + 5;
        int maxDays = 31;
        if (month == 4 || month == 6 || month == 9 || month == 11)
        {
            maxDays = 30;
        }
        else if (month == 2)
        {
            maxDays = 28;
        }
        if (day > maxDays)
        {
            day -= maxDays;
            month++;
            if (month > 12)
            {
                month = 1;
            }
            Console.WriteLine("{0}.{1:D2}", day, month);
        }
        else
        {
            Console.WriteLine("{0}.{1:D2}", day, month);
        }
    }
}
