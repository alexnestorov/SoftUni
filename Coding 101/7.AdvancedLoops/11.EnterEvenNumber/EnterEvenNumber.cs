using System;

class EnterEvenNumber
{
    static void Main()
    {
        int evenNumber = 0;
        do
        {
            try
            {
                evenNumber = int.Parse(Console.ReadLine());
                if (evenNumber % 2 == 0)
                {
                    break;
                }
                Console.WriteLine("The number is not even.");
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid number!");
            }
            
        } while (true);

        Console.WriteLine("Even number entered: {0}", evenNumber);
    }
}
