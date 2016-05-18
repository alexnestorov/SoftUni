using System;

class FigureArea
{
    static void Main()
    {
        string figure = Console.ReadLine().ToLower();
        double firstNumber = double.Parse(Console.ReadLine());
        if (figure == "square")
        {
            Console.WriteLine("{0:f3}", Math.Pow(firstNumber, 2));
        }
        else if (figure == "rectangle")
        {
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round((firstNumber*secondNumber),3));
        }
        else if (figure == "triangle")
        {
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round((firstNumber * (secondNumber / 2)), 3));
        }
        else if (figure == "circle")
        {
                Console.WriteLine(Math.Round(Math.PI * Math.Pow(firstNumber, 2),3));
        }
    }
}
