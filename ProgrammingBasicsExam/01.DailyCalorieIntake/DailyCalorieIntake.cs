using System;

class DailyCalorielongake
{
    static void Main()
    {
        long weight = long.Parse(Console.ReadLine());
        long height = long.Parse(Console.ReadLine());
        int age = int.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        long workouts = long.Parse(Console.ReadLine());
        decimal BMR = 0.0m;
        decimal coef = 0.0m;

        bool isMale = gender == 'm';
        if (isMale)
        {
            BMR = (decimal)(66.5 + (13.75 * (weight / 2.2)) + (5.003 * (height * 2.54)) - (6.755 * age));
        }
        else if (gender == 'f')
        {
            BMR = (decimal)(655 + (9.563 * (weight / 2.2)) + (1.850 * (height * 2.54)) - (4.676 * age));
        }
        if (workouts <= 0)
        {
            coef = 1.2m;
        }
        else if (workouts >= 1 && workouts <= 3)
        {
            coef = 1.375m;
        }
        else if (workouts >= 4 && workouts <= 6)
        {
            coef = 1.55m;
        }
        else if (workouts >= 7 && workouts <= 9)
        {
            coef = 1.725m;
        }
        else
        {
            coef = 1.9m;
        }
        decimal DCI = Math.Floor(BMR * coef);
        Console.WriteLine(DCI);
    }
}
