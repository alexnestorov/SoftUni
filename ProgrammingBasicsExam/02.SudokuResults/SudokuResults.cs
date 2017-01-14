using System;

class SudokuResults
{
    static void Main()
    {
        string time = "";
        string[] getSeconds = time.Split();
        int games = 0;
        double totalMinutes = 0;
        double totalSeconds = 0;
        double averageSeconds = 0.0d;
        while (games < 100)
        {
            time = Console.ReadLine().ToLower();
            if (time == "quit")
            {
                break;
            }
            getSeconds = time.Split(':');
            totalMinutes += Convert.ToDouble(getSeconds[0]);
            totalSeconds += Convert.ToDouble(getSeconds[1]);
            games++;
        }
        totalMinutes *= 60;
        averageSeconds = (totalMinutes + totalSeconds) / games;
        if (averageSeconds < 720)
        {
            Console.WriteLine("Gold Star \nGames - {0} \\ Average seconds - {1:F0}", games, Math.Ceiling(averageSeconds));
        }
        else if (averageSeconds >= 720 && averageSeconds <= 1440)
        {
            Console.WriteLine("Silver Star \nGames - {0} \\ Average seconds - {1:F0}", games, Math.Ceiling(averageSeconds));
        }
        else if (averageSeconds > 1440)
        {
            Console.WriteLine("Bronze Star \nGames - {0} \\ Average seconds - {1:F0}", games, Math.Ceiling(averageSeconds));
        }
    }
}
