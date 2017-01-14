using System;

class BaiIvanAdventures
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        decimal money = decimal.Parse(Console.ReadLine());
        decimal drinkQuantity = decimal.Parse(Console.ReadLine());
        decimal alcohol = 0.0m;
        string condition = "";

        switch (day)
        {
            case 0: alcohol = money / 25.0m;
                break;
            case 1: alcohol = money / 21.0m;
                break;
            case 2: alcohol = money / 14.0m;
                break;
            case 3: alcohol = money / 17.0m;
                break;
            case 4: alcohol = money / 45.0m;
                break;
            case 5: alcohol = money / 59.0m;
                break;
            case 6: alcohol = money / 42.0m;
                break;
        }
        if (alcohol > 1.5m)
        {
            condition = "very drunk";

        }
        else if (alcohol <= 1.5m && alcohol >= 1.0m)
        {
            condition = "drunk";
        }
        else if (alcohol < 1.0m)
        {
            condition = "sober";
        }
        if (alcohol > drinkQuantity)
        {
            Console.WriteLine("Bai Ivan is {0} and very happy and he shared {1:F2} l. of alcohol with his friends"
                            , condition
                            , alcohol - drinkQuantity);
        }
        else if (alcohol == drinkQuantity)
        {
            Console.WriteLine("Bai Ivan is {0} and happy. He is as drunk as he wanted",condition);
        }
        else
        {
            Console.WriteLine("Bai Ivan is {0} and quite sad. He wanted to drink another {1:F2} l. of alcohol"
                , condition
                , drinkQuantity - alcohol);
        }
    }
}
