using System;
using System.Text;

/*
 * Find Intersection
Have the function FindIntersection(strArr) read the array of strings stored in strArr which will contain 2 elements: 
the first element will represent a list of comma-separated numbers sorted in ascending order, 
the second element will represent a second list of comma-separated numbers (also sorted). 
Your goal is to return a comma-separated string containing the numbers that occur in elements of strArr in sorted order. 
If there is no intersection, return the string false.
Examples
Input: new string[] {"1, 3, 4, 7, 13", "1, 2, 4, 13, 15"}
Output: 1,4,13

Input: new string[] {"1, 3, 9, 10, 17, 18", "1, 4, 9, 10"}
Output: 1,9,10
 * */
namespace CodingChallenges
{
    class MainClass
    {
        public static string FindIntersection(string[] strArr)
        {
            var result = new StringBuilder();
            foreach (var a in strArr[0].Split(','))
            {
                foreach (var b in strArr[1].Split(','))
                {
                    if (a.Trim() == b.Trim())
                    {
                        result.Append(a.Trim() + ",");
                    }
                }
            }

            if (result.Length == 0)
                return "false";

            result = result.Remove(result.Length - 1, 1);

            return result.ToString();
        }
        static void Main()
        {
            //Console.WriteLine(FindIntersection(Console.ReadLine()));
            Console.WriteLine(FindIntersection(new string[] {"1, 3, 9, 10, 17, 18", "1, 4, 9, 10"}));
        }
    }
}