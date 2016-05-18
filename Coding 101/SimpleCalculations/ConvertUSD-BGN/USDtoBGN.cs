using System;

    class USDtoBGN
    {
        static void Main()
        {
            var bgn = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(bgn* 1.79549, 2)+" BGN");
        }
    }
