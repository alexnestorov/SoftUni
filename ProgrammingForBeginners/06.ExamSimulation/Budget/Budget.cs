using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Budget
{
    static void Main()
    {
        int money = int.Parse(Console.ReadLine());
        int weekDays = int.Parse(Console.ReadLine());
        int hometownWeekends = int.Parse(Console.ReadLine());
        int totalDays = 30;
        int rent = 150;
        int weekends = 4;
        int weekendsSpend = (weekends - hometownWeekends) * 2 * 20;
        double weekdaysSpend = weekDays * ((int)(0.03 * money) + 10);
        double normalDays = (totalDays - weekends * 2 - weekDays) * 10;
        double result = money - rent - weekdaysSpend - weekendsSpend - normalDays;
        if (result > 0)
        {
            Console.WriteLine("Yes, leftover {0}.", result);
        }
        else if (result == 0)
        {
            Console.WriteLine("Exact Budget.");
        }
        else
        {
            Console.WriteLine("No, not enough {0}.", Math.Abs(result));
        }
    }
}
