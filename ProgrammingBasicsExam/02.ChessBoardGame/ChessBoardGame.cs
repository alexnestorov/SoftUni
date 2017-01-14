using System;

class ChessBoardGame
{
    static void Main()
    {
            // Enter an odd number between 1 and 9.
            // Input variables for decimal number character, black and white team and counter of the characters.
        int chessBoard = int.Parse(Console.ReadLine());
        string gameName = Console.ReadLine();
        int asciiNumber = 0;
        int blackFigures = 0;
        int whiteFigures = 0;
        int countCharacters = 0;

            // Main Logic get the number of every character.
            // Check the game name is bigger than the chessBoard. If it's true exit the loop and print result.
            // Check if the character is odd or even number. If it is odd - black team, if it is even - white team
            // Check if the character is a letter or digit and sum to one of the teams.
            // Check if the character is a capital letter and sum it to the opposite team.
        foreach (char letter in gameName)
        {
            int digit = (int)letter;
            asciiNumber = digit;
            bool isLetterOrDigit = ((asciiNumber >= 48 && asciiNumber <= 57) || (asciiNumber >= 65
                && asciiNumber <= 90) || (asciiNumber >= 97 && asciiNumber <= 122));
            bool isCapitalLetter = (asciiNumber >= 65 && asciiNumber <= 90);
            countCharacters++;
            if (countCharacters > chessBoard * chessBoard)
            {
                break;
            }
            if (isLetterOrDigit)
            {
                if (countCharacters % 2 == 0)
                {
                    if (isCapitalLetter)
                    {
                        blackFigures += asciiNumber;
                    }
                    else
                    {
                        whiteFigures += asciiNumber;
                    }
                }
                else if (countCharacters % 2 != 0)
                {
                    if (isCapitalLetter)
                    {
                        whiteFigures += asciiNumber;
                    }
                    else
                    {
                        blackFigures += asciiNumber;
                    } 
                }
            }
        }

            // Output. Print result winning team and difference or draw result.
        if (blackFigures > whiteFigures)
        {
            Console.WriteLine("The winner is: black team\n{0}", Math.Abs(whiteFigures - blackFigures));
        }
        else if (blackFigures < whiteFigures)
        {
            Console.WriteLine("The winner is: white team\n{0}", Math.Abs(whiteFigures - blackFigures));
        }
        else if (blackFigures == whiteFigures)
        {
            Console.WriteLine("Equal result: {0}", blackFigures);
        }
    }
}
