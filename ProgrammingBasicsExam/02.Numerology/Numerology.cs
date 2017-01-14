using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Numerology
{
    static void Main()
    {
        string input = Console.ReadLine();

        // Split input datainto string arrays
        string[] array = input.Split(' ');
        string name = array[1];
        string date = array[0];
        string[] numbers = date.Split('.');

        // Maing logic.
        long dateValue = 1;
        dateValue = MultiplyDateValues(numbers, dateValue);

        dateValue = AddNameLetterValues(name, dateValue);

        int sumDigits = GetValueSumOfDigits(ref dateValue);
        Console.WriteLine(sumDigits);
    }

    static int GetValueSumOfDigits(ref long dateValue)
    {
        int sumDigits = 0;
        if (dateValue <= 13)
        {
            sumDigits = (int)dateValue;
            Console.WriteLine(sumDigits);
        }
        else
        {
            while (dateValue > 0)
            {
                sumDigits += (int)(dateValue % 10);
                dateValue /= 10;
                if (dateValue == 0 && sumDigits > 13)
                {
                    dateValue = sumDigits;
                    sumDigits = 0;
                }
            }
        }

        return sumDigits;
    }

    static long MultiplyDateValues(string[] numbers, long dateValue)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            dateValue *= int.Parse(numbers[i]);
        }
        long month = long.Parse(numbers[1]);
        if (month % 2 == 1)
        {
            dateValue *= dateValue;
        }

        return dateValue;
    }

    static long AddNameLetterValues(string name, long dateValue)
    {
        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] >= 'a' && name[i] <= 'z')
            {
                dateValue += name[i] - 'a' + 1;
            }
            else if (name[i] >= 'A' && name[i] <= 'Z')
            {
                dateValue += 2 * (name[i] - 'A' + 1);
            }
            else if (char.IsDigit(name[i]))
            {
                dateValue += name[i] - '0';
            }
        }

        return dateValue;
    }
}
