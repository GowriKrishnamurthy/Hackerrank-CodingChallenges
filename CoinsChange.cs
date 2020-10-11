using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MainClass
{
    public static string CoinsChange(int amount)
    {
        List<int> coinsDenominations = new List<int> { 500, 200, 100, 50};
        string result = string.Empty;

        foreach (var coin in coinsDenominations)
        {
            int coinsUsed = amount / coin;
            amount = amount - (coinsUsed * coin);
            
            if(coinsUsed > 0)
                result += $"{coin} coins used: {coinsUsed}. ";
        }

        return result.TrimEnd('.') + $" and remaining amount: {amount}";
    }

    static void Main()
    {
        Console.WriteLine("Enter amount");
        int.TryParse(Console.ReadLine(), out int amount);
        if(amount > 0)
            Console.WriteLine(CoinsChange(amount));
    }     
}
