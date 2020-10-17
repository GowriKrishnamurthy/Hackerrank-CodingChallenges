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
            /* 
             * 3. Given a sequence of numbers, find the length of the longest subarray of increasing numbers

               Input is like this
                5
                1 9 2 3 6

                Ans: 3

                7
                1 1 2 4 3 2 4 7

                Ans: 4
             */
            Console.WriteLine("Enter n");
            int.TryParse(Console.ReadLine(), out int n);
            List<int> subSeq = new List<int>();
            List<int> longestSeq = new List<int>();
            if (n > 0)
            {
                Console.WriteLine("Enter numbers ");
                int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
                
                subSeq.Add(numbers[0]);
                for (int i = 1; i < n; i++)
                {   
                    if ( numbers[i] - numbers[i-1] >=0)
                        subSeq.Add(numbers[i]);
                    else
                    {
                        if (subSeq.Count > longestSeq.Count)
                        {
                            longestSeq = new List<int>(subSeq);
                        }
                        subSeq.Clear();
                        subSeq.Add(numbers[i]);
                    }
                }
            }
            Console.WriteLine(Math.Max(subSeq.Count, longestSeq.Count));
        }
    }
}
