using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

class MainClass
{
    /*
    * Print out, in reverse order, every multiple of 3 between 1 and 200.
    */

    static void PrintMultiplesOf3InReverseOrder()
    {
        for (int i = 30; i > 0; i--)
        {
            if (i % 3 == 0)
                Console.WriteLine(i);
        }
    }

    /*
     * Prints the numbers from 1 to 100. 
     * But for multiples of three print "3X" instead of the number 
     * and for the multiples of five print "5X". 
     * For numbers which are multiples of both three and five print "3X5X"
     */
    static void MultiplesOf3And5()
    {
        for (int i = 1; i <= 30; i++)
        {
            if (i % 15 == 0)
                Console.WriteLine("3X5X");
            else if (i % 5 == 0)
                Console.WriteLine("5X");
            else if (i % 3 == 0)
                Console.WriteLine("3X");
            else
                Console.WriteLine(i);
        }
    }
    /*
     * Find the minimum value in a list
     * */
    static void MinimumuNumberInList(string numbers)
    {
        Console.WriteLine(numbers.Split(',').Select(x => double.Parse(x)).Min());
    }

    /*
     * check if a given number is Lucky (all digits are different)
     *  Input: n = 983
        Output: true
        All digits are different

        Input: n = 9838
        Output: false
        8 appears twice
     * */
    static bool LuckyNumber(string num)
    {
        double.TryParse(num, out double val);

        bool[] arr = new bool[num.Length];

        // Traverse through all digits of given number 
        while (val > 0)
        {
            // Find the last digit 
            int digit = (int)val % 10;

            // If digit is already seen return false 
            if (arr[digit])
                return false;

            // Mark this digit as seen 
            arr[digit] = true;

            // Remove the last digit from number 
            val = val / 10;
        }
        return true;
    }

    /*
     * Highest power of 2 less than or equal to given number
     * Given a number n, find the highest power of 2 that is smaller than or equal to n.
    Input : n = 10      Output : 8
    Input : n = 19      Output : 16
    Input : n = 32      Output : 32
    */
    static int HighestPowerOf2(string num)
    {
        int res = 0;
        int.TryParse(num, out int val);
        for (int i = val; i >= 1; i--)
        {
            // If i is a power of 2 
            if ((i & (i - 1)) == 0)
            {
                res = i;
                break;
            }
        }
        return res;
    }

    static void Main()
    {
        // PrintMultiplesOf3InReverseOrder();
        // MultiplesOf3And5();

        //MinimumuNumberInList(Console.ReadLine()); // Key in numbers separated by comma
        //Console.WriteLine(LuckyNumber(Console.ReadLine()));
        Console.WriteLine(HighestPowerOf2(Console.ReadLine()));        
    }
}

