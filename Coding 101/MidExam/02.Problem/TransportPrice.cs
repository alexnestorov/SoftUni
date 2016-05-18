using System;

class TransportPrice
{
    static void Main()
    {
        int kilometres = int.Parse(Console.ReadLine());
        string dayOrNight = Console.ReadLine().ToLower();

        double priceTaxiDay = (kilometres * 0.79) + 0.7;
        double priceTaxiNight = (kilometres * 0.90) + 0.7;
        double priceBusDayNight = kilometres * 0.09;
        double priceTrainDayNight = kilometres * 0.06;

        double result = 0;
        if (kilometres < 20)
        {
            if (dayOrNight == "day")
            {
                result = priceTaxiDay;
            }
            else
            {
                result = priceTaxiNight;
            }
        }
        else if (kilometres >= 20 && kilometres < 100)
        {
            if (dayOrNight == "day")
            {
                if (priceTaxiDay > priceBusDayNight)
                {
                    result = priceBusDayNight;
                }
                else
                {
                    result = priceTaxiDay;
                }
            }
            else if (dayOrNight == "night")
            {
                if (priceTaxiNight > priceBusDayNight)
                {
                    result = priceBusDayNight;
                }
                else
                {
                    result = priceTaxiNight;
                }
            }
        }
        else if (kilometres >= 100)
        {
            if (dayOrNight == "day")
            {
                if (priceTaxiDay > priceTrainDayNight)
                {
                    result = priceTrainDayNight;
                }
                else
                {
                    result = priceTaxiDay;
                }
            }
            else if (dayOrNight == "night")
            {
                if (priceTaxiNight > priceTrainDayNight)
                {
                    result = priceTrainDayNight;
                }
                else
                {
                    result = priceTaxiNight;
                }
            }
        }
        Console.WriteLine(result);
    }
}
