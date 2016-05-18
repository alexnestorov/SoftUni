using System;
using System.Collections.Generic;
using System.Linq;

class GameOfNames
{
    static void Main()
    {
        // Input.
        int countOfPlayers = int.Parse(Console.ReadLine());
        Dictionary<string, int> playerScore = new Dictionary<string, int>();

        // Main logic. Add every player and score to dictionary.
        for (int i = 0; i < countOfPlayers; i++)
        {
            // Read player name and start score.
            string name = Console.ReadLine();
            int score = int.Parse(Console.ReadLine());

            score = UpdatePlayerScore(name, score);

            AddPlayerNameAndScore(playerScore, name, score);
        }

        // Sort score in descending order.
        var descending = from pair in playerScore
                         orderby pair.Value descending
                         select pair;
        
        // Print max result.
        foreach (var max in descending)
        {
            Console.WriteLine("The winner is {0} - {1} points", max.Key, max.Value);
            return;
        }
    }

    static void AddPlayerNameAndScore(Dictionary<string, int> playerScore, string name, int score)
    {
        // If name exist the score is replaced.
        if (playerScore.ContainsKey(name))
        {
            playerScore[name] = score;
        }
        else
        {
            playerScore.Add(name, score);

        }
    }

    static int UpdatePlayerScore(string name, int score)
    {
        for (int j = 0; j < name.Length; j++)
        {
            if (name[j] % 2 == 0)
            {
                score += name[j];
            }
            else
            {
                score -= name[j];
            }
        }

        return score;
    }
}

