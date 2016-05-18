using System;

class NumberToText
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string[] numWords = new string[] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"};
        if (number >=0 && number < 10)
        {
            Console.WriteLine(numWords[number]);
        }
        else if (number >= 10)
        {
            Console.WriteLine("number too big");
        }
    }
}
