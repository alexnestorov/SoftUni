using System;

class Histogram
{
    static void Main()
    {
        // Input and declared variables.
        int n = int.Parse(Console.ReadLine());
        int input = 0;
        double p1 = 0;
        double p2 = 0;
        double p3 = 0;
        double p4 = 0;
        double p5 = 0;

        //Main Logic. Add each number to declared diapazon. 
        for (int i = 0; i < n; i++)
        {
            input = int.Parse(Console.ReadLine());
            if (input < 200)
            {
                p1++;
            }
            else if (input >= 200 && input <=399)
            {
                p2++;
            }
            else if (input >= 400 && input <= 599)
            {
                p3++;
            }
            else if (input >= 600 && input <= 799)
            {
                p4++;
            }
            else if (input >= 800 && input <= 1000)
            {
                p5++;
            }
        }

        // Output.
        Console.WriteLine("{0:F2}%", (p1 / n) * 100);
        Console.WriteLine("{0:F2}%", (p2 / n) * 100);
        Console.WriteLine("{0:F2}%", (p3 / n) * 100);
        Console.WriteLine("{0:F2}%", (p4 / n) * 100);
        Console.WriteLine("{0:F2}%", (p5 / n) * 100);
    }
}
