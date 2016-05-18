using System;

class SpecialNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            bool isSpecialNumber = false;
            int sumDigits = 0;
            int num = i;
            while (num > 0)
            {
                sumDigits += num % 10;
                num /= 10;
            }
            switch (sumDigits)
            {
                case 5:
                case 7:
                case 11:
                    isSpecialNumber = true;
                    Console.WriteLine("{0} -> {1}", i, isSpecialNumber);
                    break;
                default:
                    Console.WriteLine("{0} -> {1}", i, isSpecialNumber);
                    break;
            }
        }
    }
}
