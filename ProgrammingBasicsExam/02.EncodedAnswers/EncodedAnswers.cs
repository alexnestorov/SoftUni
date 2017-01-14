using System;

class EncodedAnswers
{
    static void Main()
    {
        // Input variables for question numbers, code number and answer variable for each answer
        // Using uint because numbers must be positive integers
        uint questionNumbers = uint.Parse(Console.ReadLine());
        uint codeNumber = 0;
        uint answerA = 0;
        uint answerB = 0;
        uint answerC = 0;
        uint answerD = 0;

        // Main logic. Enter the code number from 0.... 4 294 967 295
        // Check for remainder, print the right answer and sum answers.
        for (uint count = 0; count < questionNumbers; count++)
        {
            codeNumber = uint.Parse(Console.ReadLine());
            if (codeNumber % 4 == 0)
            {
                answerA++;
                Console.Write("a ");
            }
            else if (codeNumber % 4 == 1)
            {
                answerB++;
                Console.Write("b ");
            }
            else if (codeNumber % 4 == 2)
            {
                answerC++;
                Console.Write("c ");
            }
            else if (codeNumber % 4 == 3)
            {
                answerD++;
                Console.Write("d ");
            }
        }
        Console.WriteLine();

        // Output. Print the sum of each answer.
        Console.WriteLine("Answer A: {0}\nAnswer B: {1}\nAnswer C: {2}\nAnswer D: {3}"
            , answerA, answerB, answerC, answerD);
    }
}
