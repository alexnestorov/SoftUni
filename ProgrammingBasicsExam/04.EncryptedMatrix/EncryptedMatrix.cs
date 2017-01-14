using System;

class EncryptedMatrix
{
    static void Main()
    {
        // Input data
        string cryptedMessage = Console.ReadLine();
        char backslash = char.Parse(Console.ReadLine());


        // Get the last digit of each character in string
        int[] symbol = new int[cryptedMessage.Length];
        for (int i = 0; i < cryptedMessage.Length; i++)
        {
            symbol[i] = cryptedMessage[i] % 10;
        }
        int[] encryptedMatrix = new int[symbol.Length];

        // Encrypt the message
        for (int count = 0; count < symbol.Length; count++)
        {
            if (symbol[count] % 2 == 0)
            {
                encryptedMatrix[count] = symbol[count] * symbol[count];
            }
            else if (symbol[count] % 2 != 0)
            {
                if (count == 0)
                {
                    if (encryptedMatrix.Length == 1)
                    {
                        encryptedMatrix[count] = symbol[count];
                    }
                    else
                    {
                        encryptedMatrix[count] = symbol[count] + symbol[count + 1];
                    }
                    
                }
                else if (count == symbol.Length - 1)
                {
                    encryptedMatrix[count] = symbol[count] + symbol[count - 1];
                }
                else
                {
                    encryptedMatrix[count] += symbol[count - 1] + symbol[count] + symbol[count + 1];
                }
            }
        }
        
        // Turn the int array into string
        string message = String.Empty;
        for (int i = 0; i <= encryptedMatrix.Length - 1; i++)
        {
            message += encryptedMatrix[i];
        }

        // Print the matrix. Check for entered backslash.
        for (int row = 0; row < message.Length; row++)
        {
            for (int cols = 0; cols < message.Length; cols++)
            {
                if (backslash == '\\')
                {
                    if (cols == row)
                    {
                        Console.Write("{0} ", message[cols]);
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                else if (backslash == '/')
                {
                    if (cols == message.Length - 1 - row)
                    {
                        Console.Write("{0} ", message[message.Length - 1 - row]);
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
