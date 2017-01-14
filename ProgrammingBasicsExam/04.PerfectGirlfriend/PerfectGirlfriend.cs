using System;

class PerfectGirlfriend
{
    static void Main()
    {
        // Declare variables for result and number of dates
        int result = 0;
        int dates = 0;
        string girlFriendsName;
        // Main logic
        while (true)
        {
            string inputLine = Console.ReadLine();
            if (inputLine == "Enough dates!")
            {
                break;
            }
            string[] dataGirlfriend = inputLine.Split('\\');
            // Get the number of the day
            int dayOfWeek = 0;
            string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            for (int i = 0; i < weekDays.Length; i++)
            {
                if (dataGirlfriend[0] == weekDays[i])
                {
                    dayOfWeek = i + 1;
                }
            }
            // Get the sum of all digits of the telephone number
            string telephoneNumber = dataGirlfriend[1];
            int phoneResult = 0;
            for (int i = 0; i < telephoneNumber.Length; i++)
            {
                phoneResult += telephoneNumber[i] - '0';
            }
            // Get the value of the bra size
            string braSize = dataGirlfriend[2];
            string numberPart = braSize.Substring(0, braSize.Length - 1);
            int braSizeResult = int.Parse(numberPart);
            for (int i = 0; i < braSize.Length; i++)
            {
                if (braSize[i] >= 65 && braSize[i] <= 90)
                {
                    braSizeResult *= braSize[i];
                }
            }
            // Get the sum of the girlfriend's name.
            girlFriendsName = dataGirlfriend[3];
            int letter = 0;
            if (girlFriendsName[0] >= 'A' && girlFriendsName[0] <= 'Z')
            {
                letter += girlFriendsName[0] * girlFriendsName.Length;
            }
            result = dayOfWeek + phoneResult + braSizeResult - letter;

            // Output result. Check the result is bigger or equal to 6000.
            // If it's true the date is successfull.
            if (result >= 6000)
            {
                dates++;
                Console.WriteLine("{0} is perfect for you.", girlFriendsName);
            }
            else
            {
                Console.WriteLine("Keep searching, {0} is not for you.", girlFriendsName);
            }
        }
        // Print number of successful dates.
        Console.WriteLine(dates);
    }
}
