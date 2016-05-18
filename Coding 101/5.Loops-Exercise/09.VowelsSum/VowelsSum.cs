using System;

class VowelsSum
{
    static void Main()
    {
            // Input variables
        string word = Console.ReadLine();
        char[] vowels = {'a', 'e', 'i', 'o', 'u' };
        int vowelSum = 0;

            // Main logic
        for (int i = 0; i <= word.Length - 1; i++)
        {
            if (word[i] == vowels[0])
            {
                vowelSum += 1;
            }
            else if (word[i] == vowels[1])
            {
                vowelSum += 2;
            }
            else if (word[i] == vowels[2])
            {
                vowelSum += 3;
            }
            else if (word[i] == vowels[3])
            {
                vowelSum += 4;
            }
            else if (word[i] == vowels[4])
            {
                vowelSum += 5;
            }
        }
            
            // Output
        Console.WriteLine(vowelSum);
    }
}
