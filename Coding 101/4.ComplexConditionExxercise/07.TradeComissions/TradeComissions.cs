using System;

class TradeComissions
{
    static void Main()
    {
        string city = Console.ReadLine().ToLower();
        double sales = double.Parse(Console.ReadLine());
        double comission = 0;

        if (sales > 0 && sales <= 500) // Check between 0 and 500 and write comission //
        {
            if (city == "sofia" && sales > 0.09) comission = 0.05; // Check cases which will return value 0.00 //
            else if (city == "varna" && sales > 0.11) comission = 0.045; // Check cases which will return value 0.00 //
            else if (city == "plovdiv" && sales > 0.09) comission = 0.055; // Check cases which will return value 0.00 //
        }
        else if (sales > 500 && sales <= 1000) // Check between 500 and 1000 and write comission //
        {
            if (city == "sofia") comission = 0.07;
            else if (city == "varna") comission = 0.075;
            else if (city == "plovdiv") comission = 0.08;
        }
        else if (sales > 1000 && sales <= 10000) // Check between 1000 and 10000 and write comission //
        {
            if (city == "sofia") comission = 0.08;
            else if (city == "varna") comission = 0.10;
            else if (city == "plovdiv") comission = 0.12;
        }
        else if (sales > 10000) // Check after 10000 and write comission //
        {
            if (city == "sofia") comission = 0.12;
            else if (city == "varna") comission = 0.13;
            else if (city == "plovdiv") comission = 0.145;
        }
        if (comission * sales == 0) Console.WriteLine("error"); // Writes error message //
        else Console.WriteLine("{0:F2}", comission * sales); // Print result in console //
    }
}
