using System;

class PassionDays
{
    static void Main()
    {
        decimal moneyforShopping = decimal.Parse(Console.ReadLine());
        string shopping = "";
        decimal spendedMoney = 0.0m;
        int purchase = 0;
        do
        {
            shopping = Console.ReadLine();
        } while (shopping != "mall.Enter");

        while (true)
        {
            shopping = Console.ReadLine();
            if (shopping == "mall.Exit")
            {
                break;
            }
            int[] discountSymbol = new int[shopping.Length];
            for (int count = 0; count < shopping.Length; count++)
            {
                discountSymbol[count] = shopping[count];
                if (discountSymbol[count] == '%')
                {
                    spendedMoney = 0.5m * moneyforShopping;
                    if (spendedMoney <= 0)
                    {
                        continue;
                    }
                    moneyforShopping -= spendedMoney;
                    purchase++;
                }
                else if (discountSymbol[count] >= 'A' && discountSymbol[count] <= 'Z')
                {
                    spendedMoney = 0.5m * discountSymbol[count];
                    if (spendedMoney > moneyforShopping)
                    {
                       continue;
                    }
                    moneyforShopping -= spendedMoney;
                    purchase++;
                }
                else if (discountSymbol[count] >= 'a' && discountSymbol[count] <= 'z')
                {
                    spendedMoney = 0.3m * discountSymbol[count];
                    if (spendedMoney > moneyforShopping)
                    {
                        continue;
                    }
                    moneyforShopping -= spendedMoney;
                    purchase++;
                }
                else if (discountSymbol[count] == '*')
                {
                    moneyforShopping += 10;
                }
                else
                {
                    spendedMoney = discountSymbol[count];
                    if (spendedMoney > moneyforShopping)
                    {
                        continue;
                    }
                    moneyforShopping -= spendedMoney;
                    purchase++;
                }
            }
        }
        if (purchase == 0)
        {
            Console.WriteLine("No purchases. Money left: {1:F2} lv.", purchase, moneyforShopping);
        }
        else
        {
            Console.WriteLine("{0} purchases. Money left: {1:F2} lv.", purchase, moneyforShopping);
        }

    }
}
