using System;

class LightTheTorcher
{
    static void Main()
    {
        int oddNumber = int.Parse(Console.ReadLine());
        string inputLine = Console.ReadLine();
        // Get values from string example inputLine = "LD".... arr is "LDLDL"
        string[] arr = new string[oddNumber];
        for (int i = 0; i < oddNumber; i++)
        {
            arr[i] = inputLine[i % inputLine.Length].ToString();
        }
        //Console.WriteLine("   - Start");
        //Command steps
        string command = Console.ReadLine().ToLower();

        int startPosition = oddNumber / 2;

        while (command != "end")
        {
            string[] arrCommand = command.Split(' ');
            // If command is right check for steps are more than the rooms.
            // If true the current position is in the last room and switch the room positon.
            // If false the current position is start + command steps + 1 and switch the room position
            if (arrCommand[0].Equals("right"))
            {
                if (startPosition + 1 + int.Parse(arrCommand[1].ToString()) >= arr.Length - 1)
                {
                    int nextPosition = arr.Length - 1;
                    if (nextPosition != startPosition)
                    {
                        startPosition = arr.Length - 1;
                        if (arr[startPosition] == "L")
                        {
                            arr[startPosition] = "D";
                        }
                        else
                        {
                            arr[startPosition] = "L";
                        }
                    }
                }
                else
                {
                    startPosition = startPosition + 1 + int.Parse(arrCommand[1].ToString());
                    if (arr[startPosition] == "L")
                    {
                        arr[startPosition] = "D";
                    }
                    else
                    {
                        arr[startPosition] = "L";
                    }
                }
            }
            // If command is left check for steps are less than zero.
            // If true the current position is in the first room and switch the room positon.
            // If false the current position is start - command steps - 1 and switch the room position
            else if (arrCommand[0].Equals("left"))
            {
                if (startPosition - 1 - int.Parse(arrCommand[1].ToString()) <= 0)
                {
                    int nextPosition = 0;
                    if (nextPosition != startPosition)
                    {
                        startPosition = 0;
                        if (arr[startPosition] == "L")
                        {
                            arr[startPosition] = "D";
                        }
                        else
                        {
                            arr[startPosition] = "L";
                        }
                    }
                }
                else
                {
                    startPosition = startPosition - 1 - int.Parse(arrCommand[1].ToString());
                    if (arr[startPosition] == "L")
                    {
                        arr[startPosition] = "D";
                    }
                    else
                    {
                        arr[startPosition] = "L";
                    }
                }
            }
            command = Console.ReadLine().ToLower();
        }
        // Calculate the left dark rooms in the basement
        int counterDRooms = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == "D")
            {
                counterDRooms++;
            }
            //Console.Write(arr[i]);
        }
        //Console.WriteLine("   - End");
        // Result = number dark rooms multiply by ASCII code 'D'
        Console.WriteLine(counterDRooms * (int)('D'));
    }
}
