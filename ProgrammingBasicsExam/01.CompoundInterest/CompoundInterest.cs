using System;

class CompoundInterest
{
    static void Main()
    {
            // Input variables price TV, bank loan term and interest rate, friend interest rate
        double priceTV = double.Parse(Console.ReadLine());
        int yearsBankTerm = int.Parse(Console.ReadLine());
        double interestRate = double.Parse(Console.ReadLine());
        double friendInterestRate = double.Parse(Console.ReadLine());

            // Calculate which loan is better
        double futureValueLoan = priceTV * Math.Pow(1 + interestRate, yearsBankTerm);
        double friendValueLoan = priceTV * (1 + friendInterestRate);
        bool isBankLoan = futureValueLoan < friendValueLoan;

            // Output. Print result
        if (isBankLoan)
        {
            Console.WriteLine("{0:F2} Bank", futureValueLoan);
        }
        else
        {
            Console.WriteLine("{0:F2} Friend", friendValueLoan);
        }
    }
}
