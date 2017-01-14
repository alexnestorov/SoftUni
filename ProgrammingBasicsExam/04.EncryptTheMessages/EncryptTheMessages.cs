using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EncryptTheMessages
{
    static void Main()
    {
        string message = "";
        int messageCount = 0;
        // List<string> alphabet = new List<string>();
        List<string> decryptMessage = new List<string>();
        //for (char i = 'A'; i <= 'Z'; i++)
        //{
        //    alphabet.Add(i.ToString());
        //}
        //Console.WriteLine(string.Join(" ", alphabet));
        do
        {
            message = Console.ReadLine();
        } while (message != "start" && message != "START");

        while (true)
        {
            message = Console.ReadLine();
            if (message == "end" || message == "END")
            {
                break;
            }
            if (message == "") // If message is empty continue to next message
            {
                continue;
            }
            else
            {
                messageCount++;
            }
            for (int i = message.Length - 1; i >= 0; i--)
            {
                ConvertSymbols(message, decryptMessage, i);
            }
            decryptMessage.Add("-"); // Separator between every decrypt message
        }

        if (messageCount == 0)
        {
            Console.WriteLine("No messages sent.");
        }
        else
        {
            Console.WriteLine("Total number of messages: {0}", messageCount);
            PrintDecryptMessages(decryptMessage); // Print every decrypt message on a single line.
        }
    }

    static void PrintDecryptMessages(List<string> decryptMessage)
    {
        foreach (var item in decryptMessage)
        {
            if (item == "-")
            {
                Console.WriteLine();
            }
            else
            {
                Console.Write(item);
            }
        }
    }

    static void ConvertSymbols(string message, List<string> decryptMessage, int i)
    {
        if ((message[i] >= 'A' && message[i] <= 'M') || (message[i] >= 'a' && message[i] <= 'm'))
        {
            ConvertLettersFromAtoNToMtoZ(message, decryptMessage, i);
        }
        else if ((message[i] >= 'M' && message[i] <= 'Z') || (message[i] >= 'm' && message[i] <= 'z'))
        {
            ConvertLettersFromMtoZToAtoN(message, decryptMessage, i);
        }
        else if (message[i] == ' ')
        {
            decryptMessage.Add("+");
        }
        else if (message[i] == ',')
        {
            decryptMessage.Add("%");
        }
        else if (message[i] == '.')
        {
            decryptMessage.Add("&");
        }
        else if (message[i] == '?')
        {
            decryptMessage.Add("#");
        }
        else if (message[i] == '!')
        {
            decryptMessage.Add("$");
        }
        else if (message[i] >= '0' && message[i] <= '9')
        {
            decryptMessage.Add(message[i].ToString());
        }
    }

    static void ConvertLettersFromAtoNToMtoZ(string message, List<string> decryptMessage, int i)
    {
        int local = message[i] + 13;
        char result = (char)local;
        decryptMessage.Add(result.ToString());
    }

    static void ConvertLettersFromMtoZToAtoN(string message, List<string> decryptMessage, int i)
    {
        int local = message[i] - 13;
        char result = (char)local;
        decryptMessage.Add(result.ToString());
    }
}
