using System;

class SumNumbersBy3
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());
        int sum1 = 0;
        int sum2 = 0;
        int sum3 = 0;
        for (int i = 0; i < numbers; i++)
        {
            int num = int.Parse(Console.ReadLine());
          
            if (i % 3 == 0)
            {
                sum1 += num;
            }
            else if (i % 3 == 1)
            {
                sum2 += num;
            }
            else if(i % 3 == 2)
            {
                sum3 += num;
            }
        }

        Console.WriteLine("sum1 = {0}\nsum2 = {1}\nsum3 = {2}", sum1, sum2, sum3);
    }
}
