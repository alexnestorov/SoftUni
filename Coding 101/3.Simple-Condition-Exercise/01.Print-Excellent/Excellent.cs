using System;

class Excellent
{
    static void Main()
    {
        double resultExam = double.Parse(Console.ReadLine());
        if (resultExam >= 5.50 && resultExam <= 6)
        {
            Console.WriteLine("Excellent!");
        }
    }
}