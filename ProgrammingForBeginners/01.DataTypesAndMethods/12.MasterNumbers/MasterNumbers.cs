using System;

class MasterNumbers
{
    static void Main() // Main Method print master numbers
    {
        int n = int.Parse(Console.ReadLine());

        for (int number = 1; number <= n; number++)
        {
            if (MasterNumber(number))
            {
                Console.WriteLine(number);
            }
        }
    }
    static bool MasterNumber(int number) // Check if all conditions are true the number is master
    {
        if (DivisibleBy7(number) % 7 == 0 && ContainsEvenDigit(number) && IsPalindrome(number))
        {
            return true;
        }
        return false;
    }
    static int DivisibleBy7(int number) // Method check sum of digits can be divided by 7
    {
        int numbersDivisible7 = 0;
        while (number > 0)
        {
            numbersDivisible7 += number % 10;
            number /= 10;
        }
        return numbersDivisible7;
    }
    static bool ContainsEvenDigit(int number) // Method check if the number has at least one even digit
    {
        int numberDigitEven = number;
        while (number > 0)
        {
            switch (numberDigitEven % 10)
            {
                case 0:
                case 2:
                case 4:
                case 6:
                case 8:
                    return true;
                default:
                    numberDigitEven /= 10;
                    break;
            }

            number /= 10;
        }
        return false;
    }
    static bool IsPalindrome(int number) // Method check if first and last digit are the same and so on.
    {
        string digits = "" + number;
        for (int i = 0; i < digits.Length / 2; i++)
        {
            if (digits[i] != digits[digits.Length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}
