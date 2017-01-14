using System;

class BookProblem
{
    static void Main()
    {
        // Input variables
        int numberPages = int.Parse(Console.ReadLine());
        int campingDays = int.Parse(Console.ReadLine());
        int readPagesPerDay = int.Parse(Console.ReadLine());

        // Calculate years and days to read the book pages
        int readingDays = 30 - campingDays;
        double monthsAll = 0;
        double years = 0;
        double months = 0;
        // Check if reading days and reading pages per day are bigger than zero calculate else result is never
        if (readingDays > 0 && readPagesPerDay > 0)
        {
            monthsAll = (double)(numberPages / (double)(readPagesPerDay * readingDays));
            years = monthsAll / 12;
            months = Math.Ceiling(monthsAll % 12);
            Console.WriteLine("{0:F0} years {1:F0} months", years, months);
        }
        else
        {
            Console.WriteLine("never");
        }
    }

}