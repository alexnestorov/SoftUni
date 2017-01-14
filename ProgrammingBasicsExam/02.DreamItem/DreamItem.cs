using System;

class DreamItem
{
    static void Main()
    {
        string inputLine = Console.ReadLine().ToLower();
        
        // Convert input data into variables
        string[] dataInput = inputLine.Split('\\');
        decimal moneyPerHour = decimal.Parse(dataInput[1]);
        int HoursPerDay = int.Parse(dataInput[2]);
        decimal ItemPrice = decimal.Parse(dataInput[3]);

        // Working days per month check
        int workingDays = 0;
        if (dataInput[0] == "jan" || dataInput[0] == "march" || dataInput[0] == "may" || dataInput[0] == "july"
            || dataInput[0] == "aug" || dataInput[0] == "oct" || dataInput[0] == "dec")
        {
            workingDays += 21;
        }
        else if (dataInput[0] == "apr" || dataInput[0] == "june" || dataInput[0] == "sept" || dataInput[0] == "nov")
        {
            workingDays += 20;
        }
        else if (dataInput[0] == "feb")
        {
            workingDays += 18;
        }
        // Give the amount of the salary
        decimal salary = moneyPerHour * HoursPerDay * workingDays;
        if (salary > 700m)
        {
            salary += salary * 0.1m;
        }

        // Output result
        if (salary >= ItemPrice)
        {
            Console.WriteLine("Money left = {0:F2} leva.", Math.Abs(salary - ItemPrice));
        }
        else
        {
            Console.WriteLine("Not enough money. {0:F2} leva needed.", Math.Abs(salary - ItemPrice));
        }
    }
}
