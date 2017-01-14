using System;

class DetectiveBoev
{
    static void Main()
    {
        string secretWord = Console.ReadLine();
        string encryptedMessage = Console.ReadLine();
        int resultWord = 0;
        // Get the result of characters on the secret word
        foreach (var symbol in secretWord)
        {
            resultWord += symbol;
        }
        // Calculate the mask sum.
        int finalResult = 0;
        int mask = 0;
        for (int count = resultWord; count > 0; count /= 10)
        {
            finalResult += count % 10;
        }
        // Additonal check if the mask is bigger then 9.
        // If true sum again all digits. Else sum mask.
        if (finalResult > 9)
        {
            for (int i = finalResult; i > 0; i /= 10)
            {
                mask += i % 10;
            }
        }
        else
        {
            mask += finalResult;
        }
        // Encrypt the message.
        int[] arrayMessage = new int[encryptedMessage.Length];
        for (int i = 0; i < encryptedMessage.Length; i++)
        {
            if (encryptedMessage[i] % mask == 0)
            {
                arrayMessage[i] = encryptedMessage[i] + mask;
            }
            else
            {
                arrayMessage[i] = encryptedMessage[i] - mask;
            }
        }
        // Print the crypted message in reverse order
        char cryptedMessage;
        for (int count = arrayMessage.Length - 1 ; count >= 0; count--)
        {
            cryptedMessage = (char)arrayMessage[count];
            Console.Write(cryptedMessage);
        }
        Console.WriteLine();
    }
}
