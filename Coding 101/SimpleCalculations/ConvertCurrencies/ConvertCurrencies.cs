using System;

class ConvertCurrencies
{
    static void Main()
    {
        //Input data//
        var value = double.Parse(Console.ReadLine());
        string currencyInput = Console.ReadLine().ToUpper();
        string currencyOutput = Console.ReadLine().ToUpper();
        //Exchange rates between currencies//
        var USDtoBGN = value * 1.79549;
        var BGNtoEUR = value / 1.95583;
        var EURtoGBP = value * (1.95583 / 2.53405);
        var USDtoEUR = value * (1.79549 / 1.95583);
        var GBPtoUSD = value * (2.53405 / 1.79549);
        if (currencyInput == "USD" && currencyOutput == "BGN")
        {
            Console.WriteLine(Math.Round(USDtoBGN, 2));
        }

        if (currencyInput == "BGN" && currencyOutput == "EUR")
        {
            Console.WriteLine(Math.Round(BGNtoEUR, 2));
        }

        if (currencyInput == "EUR" && currencyOutput == "GBP")
        {
            Console.WriteLine(Math.Round(EURtoGBP, 2));
        }

        if (currencyInput == "USD" && currencyOutput == "EUR")
        {
            Console.WriteLine(Math.Round(USDtoEUR, 2));
        }

        if (currencyInput == "GBP" && currencyOutput == "USD")
        {
            Console.WriteLine(Math.Round(GBPtoUSD, 2));
        }
    }
}
