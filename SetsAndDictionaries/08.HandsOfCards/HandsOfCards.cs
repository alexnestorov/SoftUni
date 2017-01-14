//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//class HandsOfCards
//{
//    static void Main()
//    {
//        var playerPoints = new Dictionary<string, HashSet<string>>();

//        string input = Console.ReadLine();

//        while (input != "JOKER")
//        {
//            string[] player = input.Split(':')
//                                   .ToArray();

//            string[] cards = player[1].Split(new[] { ' ', ',' },StringSplitOptions.RemoveEmptyEntries)
//                                      .ToArray();

//            var temp = new HashSet<string>();
//            for (int i = 0; i < cards.Length; i++)
//            {
//                if (playerPoints.ContainsKey(player[0]))
//                {
//                    playerPoints[player[0]] = temp.Add(cards[i].ToString());
//                }
//            }
            
//            else
//            {
//                playerPoints.Add(player[0],temp);
//            }
//            input = Console.ReadLine();
//        }
//    }
//    static string[] ReadInput()
//    {
//        return Console.ReadLine()
//                                .Split(new char[] { ' ', ',', ':' }, StringSplitOptions.RemoveEmptyEntries)
//                                .ToArray();
//    }
//}
