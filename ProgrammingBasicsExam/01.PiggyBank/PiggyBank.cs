using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PiggyBank
{
    static void Main()
    {
        int tankPrice = int.Parse(Console.ReadLine());
        int partyDays = int.Parse(Console.ReadLine());
        int days = 30;
        int moneySafePerDay = 2;
        int moneySpentPerDay = 5;

        int totalSafe = (days - partyDays) * moneySafePerDay;
        int totalSpent = partyDays * moneySpentPerDay;
        int totalMoney = totalSafe - totalSpent;

        double months = (double)tankPrice / totalMoney;
        double years = Math.Truncate(months / 12);
        double singleMonths = Math.Truncate(months % 12);
        if (totalMoney <= 0)
        {
            Console.WriteLine("never");
        }
        else if (months % 12 > 11)
        {
            Console.WriteLine("{0} years, 0 months",years + 1);
        }
        else
        {
            Console.WriteLine("{0} years, {1} months", Math.Truncate(months / 12), Math.Ceiling(months % 12));
        }
    }
}
