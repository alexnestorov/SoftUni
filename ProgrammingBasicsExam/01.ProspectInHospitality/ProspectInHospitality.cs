using System;

class ProspectInHospitality
{
    static void Main()
    {
            // Input data
        long buildersAmount = long.Parse(Console.ReadLine());
        long receptionistsAmount = long.Parse(Console.ReadLine());
        long chambermaidsAmount = long.Parse(Console.ReadLine());
        long techniciansAmount = long.Parse(Console.ReadLine());
        long othersAmount = long.Parse(Console.ReadLine());
        decimal salaryNiki = decimal.Parse(Console.ReadLine());
        decimal currencyRateUSD = decimal.Parse(Console.ReadLine());
        decimal salaryMe = decimal.Parse(Console.ReadLine());
        decimal budget = decimal.Parse(Console.ReadLine());

        decimal buildersSalary = 1500.04m;
        decimal receptionistsSalary = 2102.10m;
        decimal chambermaidsSalary = 1465.46m;
        decimal techniciansSalary = 2053.33m;
        decimal othersSalary = 3010.98m;

        decimal amountSalary = buildersAmount * buildersSalary + receptionistsAmount * receptionistsSalary + chambermaidsAmount * chambermaidsSalary +
            techniciansAmount * techniciansSalary + othersAmount * othersSalary + salaryNiki * currencyRateUSD + salaryMe;

        if (amountSalary <= budget)
        {
            Console.WriteLine("The amount is: {0:F2} lv.\nYES \\ Left: {1:F2} lv.",amountSalary, budget - amountSalary);
        }
        else
        {
            Console.WriteLine("The amount is: {0:F2} lv.\nNO \\ Need more: {1:F2} lv.", amountSalary, amountSalary - budget);
        }
    }
}
