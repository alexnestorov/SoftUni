    using System;

class TextNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine()); // Enter number between 0 and 100 //

        string[] digit = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] numbersUnder20 = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] tenths = new string[] { "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        if (number < 0)
        {
            Console.WriteLine("invalid number");
        }
        else if (number <= 9)
        {
            Console.WriteLine(digit[number]);
        }
        else if (number <= 19)
        {
            Console.WriteLine(numbersUnder20[number % 10]);
        }
        else if (number % 10 == 0 && number < 100) // Write text numbers 10, 20, 30 ... 90 //
        {
            Console.WriteLine(tenths[(number / 10) - 1]);
        }
        else if (number % 10 != 0 && number < 100) // Write text numbers 21, 22, 23 ... 99 //
        {
            Console.WriteLine("{0} {1}", tenths[(number / 10) - 1], digit[number % 10]);
        }
        else if (number % 100 == 0 && number >= 100) // Write text numbers 100, 200, 300 //
        {
            Console.WriteLine("{0} hundred", digit[(number / 100)]);
        }
    }
}
