using System;

class BasketBattle
{
    static void Main()
    {
        // Input data and declared variables
        string playerToStart = Console.ReadLine().ToLower();
        int rounds = int.Parse(Console.ReadLine());
        int pointsAttempt = 0;
        string resultAttempt = "";
        int pointsNakov = 0;
        int pointsSimeon = 0;
        int roundCounter = 1;

        // Main Logic. For each round check if the round is even or odd number to switch the player turn.
        // Depends on the start player the points are given if the shot is successfull.
        for (int i = 1; i <= rounds; i++, roundCounter++)
        {
            bool oddRound = roundCounter % 2 != 0;
            bool evenRound = roundCounter % 2 == 0;
            pointsAttempt = int.Parse(Console.ReadLine());
            resultAttempt = Console.ReadLine().ToLower();
            if (playerToStart == "nakov" && oddRound && resultAttempt == "success")
            {
                pointsNakov += pointsAttempt;
            }
            else if (playerToStart == "simeon" && oddRound && resultAttempt == "success")
            {
                pointsSimeon += pointsAttempt;
            }
            else if (playerToStart == "nakov" && evenRound && resultAttempt == "success")
            {
                pointsSimeon += pointsAttempt;
            }
            else if (playerToStart == "simeon" && evenRound && resultAttempt == "success")
            {
                pointsNakov += pointsAttempt;
            }
            // If someone reach more than 500 points in that round points are not given to him.
            if (pointsNakov > 500)
            {
                pointsNakov -= pointsAttempt;
            }
            else if (pointsSimeon > 500)
            {
                pointsSimeon -= pointsAttempt;
            }
            // If someone reach exactly 500 points the loop is over.
            if (pointsNakov == 500 || pointsSimeon == 500)
            {
                //roundCounter++;
                break;
            }
            pointsAttempt = int.Parse(Console.ReadLine());
            resultAttempt = Console.ReadLine().ToLower();
            if (playerToStart == "nakov" && evenRound && resultAttempt == "success")
            {
                pointsNakov += pointsAttempt;
            }
            else if (playerToStart == "simeon" && evenRound && resultAttempt == "success")
            {
                pointsSimeon += pointsAttempt;
            }
            else if (playerToStart == "nakov" && oddRound && resultAttempt == "success")
            {
                pointsSimeon += pointsAttempt;
            }
            else if (playerToStart == "simeon" && oddRound && resultAttempt == "success")
            {
                pointsNakov += pointsAttempt;
            }
            // If someone reach more than 500 points in that round points are not given to him.
            if (pointsNakov > 500)
            {
                pointsNakov -= pointsAttempt;
            }
            else if (pointsSimeon > 500)
            {
                pointsSimeon -= pointsAttempt;
            }
            // If someone of the players reach 500 points the loop is over.
            if (pointsNakov == 500 || pointsSimeon == 500)
            {
                break;
            }
        }

        // Output data.
        // If someone reach 500 points print the winner, in which round he wins and loser's points.
        if (pointsSimeon == 500 || pointsNakov == 500)
        {
            if (pointsNakov > pointsSimeon)
            {
                Console.WriteLine("Nakov\n{0}\n{1}", roundCounter, pointsSimeon);
            }
            else
            {
                Console.WriteLine("Simeon\n{0}\n{1}", roundCounter, pointsNakov);
            }
        }
        // Print if the result is draw and equal points.
        else if (pointsSimeon == pointsNakov)
        {
            Console.WriteLine("DRAW\n{0}", pointsNakov);
        }
        // Print the winner and the difference between them.
        else
        {
            if (pointsNakov > pointsSimeon)
            {
                Console.WriteLine("Nakov\n{0}", pointsNakov - pointsSimeon);
            }
            else
            {
                Console.WriteLine("Simeon\n{0}", pointsSimeon - pointsNakov);
            }
        }
    }

}
