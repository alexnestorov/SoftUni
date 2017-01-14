using System;

class PhoneProcesses
{
    static void Main()
    {
        string battery = Console.ReadLine();
        string[] percent = battery.Split('%');
        // Convert string to number
        int capacity = int.Parse(percent[0]);
        int count = 0;
        int appCapacity = 0;
        int result = 0;

        while (true)
        {
            string application = Console.ReadLine().ToUpper();
            if (application == "END")
            {
                break;
            }
            // Separate values in strings
            string[] appPercent = application.Split(new[] { '_', '%' }); 
            appCapacity += int.Parse(appPercent[1]);
            bool chargeNeed = capacity - appCapacity <= 15;
            if (chargeNeed && (capacity > appCapacity))
            {
                result = capacity - appCapacity;
                count++;
                if (result <= 15 && result > 0)
                {
                    Console.WriteLine("Connect charger -> {0}%\nPrograms left -> {1}", result, count);
                }
            }
            else if (appCapacity < capacity)
            {
                count++;
            }
            else if (appCapacity > capacity)
            {
                Console.WriteLine("Phone off");
            }
        }
        if (result > 15)
        {
            Console.WriteLine("Successful complete -> {0} %", result);
        }
    }
}
