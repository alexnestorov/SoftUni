using System;

class Volleyball
{
    static void Main()
    {
        string typeYear = Console.ReadLine().ToLower();
        int holidays = int.Parse(Console.ReadLine());
        int numberOfTravelWeekends = int.Parse(Console.ReadLine());

        int maxVolleyWeekends = 48;
        double gamesSaturday = (maxVolleyWeekends - numberOfTravelWeekends) * 0.75;
        double gamesHolidays = holidays * 2.0 / 3;
        double gamesInVillage = numberOfTravelWeekends;
        double gamesSum = gamesSaturday + gamesHolidays + gamesInVillage;
        if (typeYear == "leap")
        {
            double gamesSumLeap = Math.Truncate(1.15 * gamesSum);
            Console.WriteLine("{0}", gamesSumLeap);
        }
        else if (typeYear == "normal")
        {
            Console.WriteLine(Math.Truncate(gamesSum));
        }
    }
}
