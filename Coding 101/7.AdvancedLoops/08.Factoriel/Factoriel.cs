using System;

class Factoriel
{
    static void Main()
    {
        int factorielN = int.Parse(Console.ReadLine());
        int result = 1;

        for (int i = 1; i <= factorielN; i++)
        {
            result *= i;
        }
        Console.WriteLine(result);
    }
}
