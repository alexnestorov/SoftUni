using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RubiksMatrix
{
    static void Main()
    {
        int[] matrixSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int row = matrixSize[0];
        int col = matrixSize[1];
        int[,] matrix = new int[row, col];
        List<int> temp = new List<int>();
        List<int> res = new List<int>();
        int index = 1;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                matrix[i, j] = index;
                //Console.Write(matrix[i,j]);
                index++;
            }
            //Console.WriteLine();
        }
        int numberOfCommands = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfCommands; i++)
        {
            string[] command = Console.ReadLine().Split(' ').ToArray();
            int targetRowCol = int.Parse(command[0].ToString());
            string direction = command[1].ToString().ToLower();
            int moves = int.Parse(command[2].ToString());
            // Insert numbers from targetRowCol to new empty list.
            if (direction == "left" || direction == "right")
            {
                moves %= row;
                for (int j = 0; j < col; j++)
                {
                    temp.Add(matrix[targetRowCol, j]);
                }
            }
            else if (direction == "up" || direction == "down")
            {
                moves %= col;
                for (int j = 0; j < col; j++)
                {
                    temp.Add(matrix[j, targetRowCol]);
                }
            }
            // TO DO MAIN LOGIC OF THE TASK.
            // If directions are left or up reverse the temp list. Example: 1 2 3 4 5 must be set to 5 4 3 2 1.
            if (direction == "left" || direction == "up")
            {
                temp.Reverse();
            }
            int k = 0;
            for (int j = 0; j < moves; j++)
            {
                res.Clear();
                int start = temp.Count - 1;
                if (k == temp.Count) // Reset the rotation to zero.
                {
                    k = 0;
                }
                for (int count = 0; count < temp.Count; count++)
                {
                    if (count == k + 1)
                    {
                        start = 0;

                    }
                    if (count <= k)
                    {
                        res.Add(temp[start - k]);
                    }
                    else
                    {
                        res.Add(temp[start]);
                    }
                    start++;
                }
                k++;

            }
            // Get back values in matrix.
            // Reverse the list if directions are left or up.
            if (direction == "left" || direction == "up")
            {
                res.Reverse();
            }
            for (int j = 0; j < res.Count; j++)
            {
                if (direction == "left" || direction == "right")
                {
                    matrix[targetRowCol, j] = res[j];
                }
                else
                {
                    matrix[j, targetRowCol] = res[j];
                }
            }
            temp.Clear();
        }

        // Output. Check each number is in start position. If not swap.
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                int value = i * row + j + 1;
                if (matrix[i, j] == value)
                {
                    Console.WriteLine("No swap required");
                }
                else
                {
                    bool swapIsDone = false;
                    for (int k = 0; k < row; k++)
                    {
                        for (int m = 0; m < col; m++)
                        {
                            if (matrix[k, m] == value)
                            {
                                Console.WriteLine("Swap ({0}, {1}) with ({2}, {3})", i, j, k, m);
                                int t = matrix[i, j];
                                matrix[i, j] = matrix[k, m];
                                matrix[k, m] = t;
                                swapIsDone = true;
                                break;
                            }
                        }
                        if (swapIsDone)
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}

