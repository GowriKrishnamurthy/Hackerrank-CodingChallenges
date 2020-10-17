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
            /* Find if in a given array the difference between each adjacent element is <= 1

            Input is like this
            4
            1 1 2 3

            Ans: YES

            5
            1 1 3 2 2
             */
            Console.WriteLine("Enter n");
            int.TryParse(Console.ReadLine(), out int n);
            bool bDiff = true;
            if (n > 0)
            {
                Console.WriteLine("Enter numbers ");
                string[] numbers = Console.ReadLine().Split(' ');

                List<int> num = new List<int>();
                for (int j = 0; j < n; j++)
                {
                    try
                    {
                        int val = int.Parse(numbers[j]);
                        num.Add(val);
                    }
                    catch
                    {
                        continue;
                    }
                }

                for (int i = 0; i < num.Count - 1; i++)
                {
                    if (bDiff != false)
                    {
                        if (num[i + 1] == num[i])
                            bDiff = true;
                        else
                        {
                            int diff =
                                num[i + 1] > num[i] ?
                                num[i + 1] - num[i] :
                                num[i] - num[i + 1];
                            if (diff <= 1)
                                bDiff = true;
                            else
                                bDiff = false;
                        }
                    }
                }
            }

            if (bDiff)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
