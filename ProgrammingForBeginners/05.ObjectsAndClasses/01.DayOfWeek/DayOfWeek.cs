using System;
using System.Linq;

class DayOfWeek
{
    static void Main()
    {
        // Enter date in int[] array split by separator '-'
        int[] date = Console.ReadLine().Split('-').Select(int.Parse).ToArray();
        // Set each int in format DateTime
        DateTime data = new DateTime(date[2], date[1], date[0]);
        Console.WriteLine(data.DayOfWeek);
    }
}
