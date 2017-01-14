using System;

class MasterHerbalist
{
    static void Main()
    {
        // Input variables
        int dailyExpenses = int.Parse(Console.ReadLine());
        string line = "";
        int hoursPerDay;
        string path;
        int price;
        int herbs = 0;
        int days = 0;
        double moneyGained = 0;

        // Main logic
        while (true)
        {
            line = Console.ReadLine().ToLower();
            if (line == "season over")
            {
                break;
            }
            string[] arrayLine = line.Split(' ');
            hoursPerDay = int.Parse(arrayLine[0]);
            path = arrayLine[1].ToUpper();
            price = int.Parse(arrayLine[2]);
            // Loop over the path array, if the symbol is 'H' add herbs. In every turn subtract one hour.
            // If the counter finish but there are still hours, resets the counter to -1.
            // If the hours get 1 or less exit the loop
            for (int count = 0; count < path.Length; count++, hoursPerDay--)
            {
                if (path[count] == 'H')
                {
                    herbs++;

                }
                if (count == path.Length - 1 && hoursPerDay > 1)
                {
                    count = -1;
                }
                if (hoursPerDay <= 1)
                {
                    break;
                }
            }
            // Sum money gained. Reset herbs and add days.
            moneyGained += herbs * price;
            days++;
            herbs = 0;
        }
        // Calculate average earning and extra money
        double averageEarning = (double)moneyGained / (double)days;
        double difference = Math.Abs(averageEarning - dailyExpenses);
        // Calculate money needed. Total expenses - money gained.
        double totalExpenses = (double)dailyExpenses * (double)days;
        double moneyNeeded = totalExpenses - moneyGained;
        // Print result
        if (averageEarning >= dailyExpenses)
        {
            Console.WriteLine("Times are good. Extra money per day: {0:F2}.", difference);
        }
        else if (averageEarning < dailyExpenses)
        {
            Console.WriteLine("We are in the red. Money needed: {0:F0}.", moneyNeeded);
        }
    }
}
