using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Gambling
{
    static void Main()
    {
        double cash = double.Parse(Console.ReadLine());
        string[] cards = Console.ReadLine().Split(' ').ToArray();
        string[] valueCards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        int points = 0;
        points = GetStrengthHand(cards, valueCards, points);
        double countLowerHands = 0;
        double totalHands = 0;
        for (int d1 = 2; d1 <= valueCards.Length + 1; d1++)
        {
            for (int d2 = 2; d2 <= valueCards.Length + 1; d2++)
            {
                for (int d3 = 2; d3 <= valueCards.Length + 1; d3++)
                {
                    for (int d4 = 2; d4 <= valueCards.Length + 1; d4++)
                    {
                        if ((d1 + d2 + d3 + d4) > points)
                        {
                            countLowerHands++;
                        }
                        totalHands++;
                    }
                }
            }
        }
        double winningPercentage = (countLowerHands / totalHands);
        double result = 2 * cash * winningPercentage;
        if (winningPercentage < 0.50)
        {
            Console.WriteLine("FOLD");
            
        }
        else
        {
            Console.WriteLine("DRAW");
        }
        Console.WriteLine("{0:F2}", result);
    }

    static int GetStrengthHand(string[] cards, string[] valueCards, int points)
    {
        for (int i = 0; i < cards.Length; i++)
        {
            if (cards[i] == valueCards[0] || cards[i] == valueCards[1] ||
                cards[i] == valueCards[2] || cards[i] == valueCards[3] ||
                cards[i] == valueCards[4] || cards[i] == valueCards[5] ||
                cards[i] == valueCards[6] || cards[i] == valueCards[7] || cards[i] == valueCards[8])
            {
                points += int.Parse(cards[i]);
            }
            else if (cards[i] == "J")
            {
                points += 11;
            }
            else if (cards[i] == "Q")
            {
                points += 12;
            }
            else if (cards[i] == "K")
            {
                points += 13;
            }
            else if (cards[i] == "A")
            {
                points += 14;
            }
        }

        return points;
    }
}
