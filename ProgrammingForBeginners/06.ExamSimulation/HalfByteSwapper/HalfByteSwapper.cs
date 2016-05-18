using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HalfByteSwapper
{
    static void Main()
    {
        string[,] matrixBits = new string[4, 8];
        for (int i = 0; i < 4; i++)
        {
            uint bitNumber = uint.Parse(Console.ReadLine());
            string currentBits = Convert.ToString(bitNumber, 2).PadLeft(32, '0');
            for (int j = 0; j < currentBits.Length; j += 4)
            {
                string groupFourBits = currentBits[j].ToString() + currentBits[j + 1] + currentBits[j + 2] + currentBits[j + 3];
                matrixBits[i, j / 4] = groupFourBits;
            }
        }

        while (true)
        {
            string[] command1 = Console.ReadLine().Split(' ').ToArray();
            if (command1[0] == "End")
            {
                break;
            }
            string[] command2 = Console.ReadLine().Split(' ').ToArray();

            // Get value of positions four bits to be swapped.
            int row1 = int.Parse(command1[0].ToString());
            int col1 =  matrixBits.GetLength(1) - 1 - int.Parse(command1[1].ToString());
            int row2 = int.Parse(command2[0].ToString());
            int col2 = matrixBits.GetLength(1) - 1 - int.Parse(command2[1].ToString());
            
            // Swap group of four bits.
            string swap = matrixBits[row1, col1];
            matrixBits[row1, col1] = matrixBits[row2, col2];
            matrixBits[row2, col2] = swap;
        }

        // Get matrix row into binary number in string array.
        string[] resultBits = new string[4];
        for (int i = 0; i < matrixBits.GetLength(0); i++)
        {
            StringBuilder currentResult = new StringBuilder();
            for (int j = 0; j < matrixBits.GetLength(1); j++)
            {
                currentResult.Append(matrixBits[i, j]);
            }
            resultBits[i] = currentResult.ToString();
        }
        
        // Return binary number into decimal number.
        for (int i = 0; i < resultBits.Length; i++)
        {
            long result = 0;
            string binaryNumber = resultBits[i];
            result = ConvertBinaryToDecimal(result, binaryNumber);
            Console.WriteLine(result);
        }
        //for (int i = 0; i < binaryNumber.Length; i++)
        //{
        //    if (binaryNumber[binaryNumber.Length - i - 1] == '0')
        //    {
        //        result += 0;
        //    }
        //    else
        //    {
        //        result += (long)(1 * Math.Pow(power, i));
        //    }
        //}

        //uint[] bitArray = new uint[4];

        //for (int i = 0; i < bitArray.Length; i++)
        //{
        //    uint n = uint.Parse(Console.ReadLine());
        //    bitArray[i] = n;
        //}
        ////Console.WriteLine(string.Join(" ", bitArray));
        //while (true)
        //{
        //    string[] command1 = Console.ReadLine().Split(' ').ToArray();
        //    if (command1[0] == "End")
        //    {
        //        break;
        //    }
        //    string[] command2 = Console.ReadLine().Split(' ').ToArray();
        //    int num1 = int.Parse(command1[0].ToString());
        //    int group1 = int.Parse(command1[1].ToString())*4;
        //    int num2 = int.Parse(command2[0].ToString());
        //    int group2 = int.Parse(command2[1].ToString()) * 4;

        //    uint fromMask = 15u << group1;
        //    uint toMask = 15u << group2;
        //    uint fromByte = (bitArray[num1] & fromMask) >> group1;
        //    uint toByte = (bitArray[num2] & toMask) >> group2;
        //    Console.WriteLine(Convert.ToString(fromByte, 2));
        //    Console.WriteLine(Convert.ToString(toByte, 2));
        //    Console.WriteLine(Convert.ToString(fromMask, 2));
        //    Console.WriteLine(Convert.ToString(toMask, 2));
        //    Console.WriteLine(Convert.ToString(bitArray[num1], 2));
        //    Console.WriteLine(Convert.ToString(bitArray[num2], 2));
        //    // zeroing the 2 groups that will be swaped
        //    bitArray[num1] &= ~fromMask;
        //    bitArray[num2] &= ~toMask;

        //    // swaping
        //    bitArray[num1] |= toByte << group1;
        //    bitArray[num2] |= fromByte << group2;
        //    Console.WriteLine(Convert.ToString(bitArray[num1], 2));
        //    Console.WriteLine(Convert.ToString(bitArray[num2], 2));
        //}
    }

    private static long ConvertBinaryToDecimal(long result, string binaryNumber)
    {
        for (int j = 0; j < binaryNumber.Length; j++)
        {
            if (binaryNumber[binaryNumber.Length - j - 1] == '0')
            {
                result += 0;
            }
            else
            {
                result += (long)(1 * Math.Pow(2, j));
            }
        }

        return result;
    }
}
