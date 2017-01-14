using System;

class FootballStatician
{
    static void Main()
    {
        decimal payment = decimal.Parse(Console.ReadLine());
        string matchDay = Console.ReadLine().ToLower();
        int matches = 0;
            // Split the entry string into first team, matchresult and second team
            // Separate by blank space and ignore spaces more than one
        string[] result = matchDay.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string firstTeam = result[0];
        string matchResult = result[1];
        string secondTeam = result[2];
        string[] teams = { "Arsenal", "Chelsea", "Everton", "Liverpool", "Manchester City", "Manchester United", "Southampton", "Tottenham" };
            // Variables to sum points for each team
        int pointsA = 0;
        int pointsC = 0;
        int pointsE = 0;
        int pointsL = 0;
        int pointsMC = 0;
        int pointsMU = 0;
        int pointsS = 0;
        int pointsT = 0;
            //Main logic loop until get the message
            //Check for the result for each team and points sum
        while (matchDay != "end of the league.")
        {
            matches++;
            result = matchDay.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            firstTeam = result[0];
            matchResult = result[1];
            secondTeam = result[2];
            if (matchResult == "1" && firstTeam == "arsenal" || matchResult == "2" && secondTeam == "arsenal")
            {
                pointsA += 3;
            }
            else if (matchResult == "1" && firstTeam == "chelsea" || matchResult == "2" && secondTeam == "chelsea")
            {
                pointsC += 3;
            }
            else if (matchResult == "1" && firstTeam == "everton" || matchResult == "2" && secondTeam == "everton")
            {
                pointsE += 3;
            }
            else if (matchResult == "1" && firstTeam == "liverpool" || matchResult == "2" && secondTeam == "liverpool")
            {
                pointsL += 3;
            }
            else if (matchResult == "1" && firstTeam == "manchestercity" || matchResult == "2" && secondTeam == "manchestercity")
            {
                pointsMC += 3;
            }
            else if (matchResult == "1" && firstTeam == "manchesterunited" || matchResult == "2" && secondTeam == "manchesterunited")
            {
                pointsMU += 3;
            }
            else if (matchResult == "1" && firstTeam == "southampton" || matchResult == "2" && secondTeam == "southampton")
            {
                pointsS += 3;
            }
            else if (matchResult == "1" && firstTeam == "tottenham" || matchResult == "2" && secondTeam == "tottenham")
            {
                pointsT += 3;
            }
            if (matchResult == "x")
            {
                if (firstTeam == "arsenal" || secondTeam == "arsenal")
                {
                    pointsA++;
                }
                if (firstTeam == "chelsea" || secondTeam == "chelsea")
                {
                    pointsC++;
                }
                if (firstTeam == "everton" || secondTeam == "everton")
                {
                    pointsE++;
                }
                if (firstTeam == "liverpool" || secondTeam == "liverpool")
                {
                    pointsL++;
                }
                if (firstTeam == "manchestercity" || secondTeam == "manchestercity")
                {
                    pointsMC++;
                }
                if (firstTeam == "manchesterunited" || secondTeam == "manchesterunited")
                {
                    pointsMU++;
                }
                if (firstTeam == "southampton" || secondTeam == "southampton")
                {
                    pointsS++;
                }
                if (firstTeam == "tottenham" || secondTeam == "tottenham")
                {
                    pointsT++;
                }
            }
            matchDay = Console.ReadLine().ToLower();
        }
            //Output data. Payment in leva and team points in alphabetical order
        Console.WriteLine("{0}lv.", Math.Round((payment * matches) * 1.94m, 2));
        Console.WriteLine("{0} - {1} points.", teams[0], pointsA);
        Console.WriteLine("{0} - {1} points.", teams[1], pointsC);
        Console.WriteLine("{0} - {1} points.", teams[2], pointsE);
        Console.WriteLine("{0} - {1} points.", teams[3], pointsL);
        Console.WriteLine("{0} - {1} points.", teams[4], pointsMC);
        Console.WriteLine("{0} - {1} points.", teams[5], pointsMU);
        Console.WriteLine("{0} - {1} points.", teams[6], pointsS);
        Console.WriteLine("{0} - {1} points.", teams[7], pointsT);
    }
}
