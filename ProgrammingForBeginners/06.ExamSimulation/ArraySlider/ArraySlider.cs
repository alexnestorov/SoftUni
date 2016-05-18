using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class ArraySlider
{
    static void Main()
    {
        BigInteger[] targetArray = Console.ReadLine()
                            .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(BigInteger.Parse)
                            .ToArray();
        string input = Console.ReadLine().TrimEnd(' ');
        string[] command;
        int offset, operand;
        char operation;
        GetCommandValues(input, out command, out offset, out operation, out operand);
        int startIndex = 0;
        while (input != "stop")
        {
            startIndex += offset;

            startIndex %= targetArray.Length;

            if (startIndex < 0)
            {
                startIndex = targetArray.Length - Math.Abs(startIndex);
            }

            CalculateTargetIndex(targetArray, operation, operand, startIndex);

            input = Console.ReadLine();
            if (input.Contains("stop"))
            {
                break;
            }
            // Return command value from input.
            GetCommandValues(input, out command, out offset, out operation, out operand);
        }
        Console.WriteLine("[{0}]", string.Join(", ", targetArray));
    }

    static void GetCommandValues(string input, out string[] command, out int offset, out char operation, out int operand)
    {
        command = input.Split(' ').ToArray();
        offset = (int.Parse)(command[0].ToString());
        operation = (char.Parse)(command[1].ToString());
        operand = (int.Parse)(command[2].ToString());
    }

    static void CalculateTargetIndex(BigInteger[] targetArray, char operation, long operand, long startIndex)
    {
        // Divide
        if (operation == '/')
        {
            targetArray[startIndex] /= operand;
        }
        // Multiply
        else if (operation == '*')
        {
            targetArray[startIndex] *= operand;
        }
        // Subtract
        else if (operation == '-')
        {
            targetArray[startIndex] -= operand;
            if (targetArray[startIndex] < 0)
            {
                targetArray[startIndex] = 0;
            }
        }
        // Bitwise add
        else if (operation == '+')
        {
            targetArray[startIndex] += operand;
        }
        // Bitwise XOR
        else if (operation == '^')
        {
            targetArray[startIndex] ^= operand;
        }
        // Bitwise OR
        else if (operation == '|')
        {
            targetArray[startIndex] |= operand;
        }
        // Bitwise AND
        else if (operation == '&')
        {
            targetArray[startIndex] &= operand;
        }
    }
}
