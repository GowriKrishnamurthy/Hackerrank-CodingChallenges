using System;

/*
 * Find Intersection
Have the function QuestionsMarks(str) take the str string parameter, 
which will contain single digit numbers, letters, and question marks, 
and check if there are exactly 3 question marks between every pair of two numbers that add up to 10.
If so, then your program should return the string true, otherwise it should return the string false. 
If there aren't any two numbers that add up to 10 in the string, then your program should return false as well.

For example: if str is "arrb6???4xxbl5???eee5" then your program should return true because there are exactly 3 question marks between 6 and 4, and 3 question marks between 5 and 5 at the end of the string.
Examples
Input: "aa6?9"
Output: falseInput: "acc?7??sss?3rr1??????5"
Output: true
 * */
namespace CodingChallenges
{
    class MainClass
    {
        public static string QuestionsMarks(string str)
        {
            bool bNum = false;
            int count = 0, sum = 0;

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    bNum = true;
                    int.TryParse(str[i].ToString(), out int num1);
                    sum += num1;
                }

                if (bNum == true && str[i] == '?')
                    count++;

                if (count >= 3 && sum == 10)
                    return "true";

            }
            return "false";
        }

        static void Main()
        {
            Console.WriteLine(QuestionsMarks(Console.ReadLine()));
        }
    }
}