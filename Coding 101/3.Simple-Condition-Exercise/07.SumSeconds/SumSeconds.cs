using System;

class SumSeconds
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int sum = a + b + c;
        int minutes = sum / 60;
        int seconds = sum % 60;

        Console.WriteLine("{0}:{1}", minutes, seconds.ToString("D2"));
        Console.WriteLine("{0}:{1}", minutes, seconds.ToString().PadLeft(2, '0'));
    }
}
