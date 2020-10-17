using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenges
{
    public class Solution
    {
        public static void Main()
        {
            /* From a Fiabnocci like Array: Find the nth element
             * 
             * Input: num1 num2 n
             * Find nth elements in the series
             */
            Console.WriteLine("*****FIBANOCCI LIKE SERIES*****");
            Console.WriteLine("Enter first 2 numbers AND nth");

            string input = Console.ReadLine();
            string[] arr = input.Split(' ');

            if (arr.Count() == 3)
            {
                int.TryParse(arr[0].ToString(), out int val1);
                int.TryParse(arr[1].ToString(), out int val2);
                int.TryParse(arr[2].ToString(), out int n);
                List<int> fibArr = new List<int>();

                if ((val1 > 0 && val1 <= 10) &&
                   (val2 > 0 && val2 <= 10) &&
                  (n > 0 && n <= 10))
                {
                    fibArr.Add(val1);
                    fibArr.Add(val2);

                    for (int i = 2; i < n; i++)
                        fibArr.Add(fibArr[i - 1] + fibArr[i - 2]);
                }

                if (fibArr.Count > 0)
                    Console.WriteLine(fibArr[n - 1].ToString());
            }
        }
    }
}
