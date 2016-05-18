using System;

class TrainingLab
{
    static void Main()
    {
        // Input
        double height = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());

        // Calculate work place per row and sum of rows
        double widthCm = width * 100;
        double heightCm = height * 100;

        double workPlace = (int)(widthCm - 100) / 70;
        double rows = (int)(heightCm) / 120;

        // Output
        double result = workPlace * rows - 3;
        Console.WriteLine(result);

    }
}
