using System;

class CheckPrime
{
    static void Main()
    {
        int primeNumber = int.Parse(Console.ReadLine());

        bool isPrime = true;
        if (primeNumber < 2)
        {
            Console.WriteLine("Not Prime");
        }
        else
        {
            for (int count = 2; count <= Math.Sqrt(primeNumber); count++)
            {
                if (primeNumber % count == 0)
                {
                    isPrime = false;
                    Console.WriteLine("Not Prime");
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("Prime");
            }
        }
    }
}
