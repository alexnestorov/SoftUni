using System;

class OnTimeForTheExam
{
    static void Main()
    {
        int hourExam = int.Parse(Console.ReadLine());
        int minuteExam = int.Parse(Console.ReadLine());
        int hourArrive = int.Parse(Console.ReadLine());
        int minuteArrive = int.Parse(Console.ReadLine());

        // Get total minutes for exam and arrive.
        // Get the difference in hours and minutes.
        int totalMinutesExam = minuteExam + hourExam * 60;
        int totalMinutesArrive = minuteArrive + hourArrive * 60;
        int onTimeMinutes = totalMinutesExam - totalMinutesArrive;
        int hours = onTimeMinutes / 60;
        int minutes = onTimeMinutes % 60;

        // Check if it is on time
        if (onTimeMinutes <= 30 && onTimeMinutes >= 0)
        {
            Console.WriteLine("On time");
            if (onTimeMinutes > 0)
            {
                Console.WriteLine("{0} minutes before the start", onTimeMinutes);
            }
        }
        // Check if it is early
        else if (onTimeMinutes > 30)
        {
            Console.WriteLine("Early");
            if (onTimeMinutes < 60)
            {
                Console.WriteLine("{0} minutes before the start", onTimeMinutes);
            }
            else if (onTimeMinutes >= 60)
            {
                Console.WriteLine("{0}:{1:D2} hours before the start", hours, minutes);
            }
        }
        // Check if it is late
        else if (onTimeMinutes < 0)
        {
            Console.WriteLine("Late");
            if (onTimeMinutes > -60 )
            {
                Console.WriteLine("{0} minutes after the start", Math.Abs(onTimeMinutes));
            }
            else if (onTimeMinutes <= - 60)
            {
                Console.WriteLine("{0}:{1:D2} hours after the start", Math.Abs(hours), Math.Abs(minutes));
            }
        }
    }
}