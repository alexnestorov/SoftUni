using System;

class Cinema
{
    static void Main()
    {
        string typeProjection = Console.ReadLine().ToLower();
        int rowsCinema = int.Parse(Console.ReadLine());
        int columnsCinema = int.Parse(Console.ReadLine());
        double priceTicket = 0;

        if (typeProjection == "premiere")
        {
            priceTicket = 12.00;
        }
        else if (typeProjection == "normal")
        {
            priceTicket = 7.50;
        }
        else if (typeProjection == "discount")
        {
            priceTicket = 5.00;
        }
        double capacity = rowsCinema * columnsCinema * priceTicket;
        Console.WriteLine("{0:f2} leva", capacity);
    }
}
