using System;
using System.Linq;
using System.Text.RegularExpressions;

/*
 * Have the function LongestWord(sen) take the sen parameter being passed and return the largest word in the string. 
 * If there are two or more words that are the same length, return the first word from the string with that length. 
 * Ignore punctuation and assume sen will not be empty.

Examples
Input: "fun&!! time"
Output: time

Input: "I love dogs"
Output: love
 * */
namespace CodingChallenges
{
    class MainClass
    {
        public static string LongestWord2(string sen)
        {
            string oneWord = string.Empty;
            Regex regx = new Regex(@"[^\w\s]");
            sen = regx.Replace(sen, "");

            foreach (string item in sen.Split(' '))
            {
                if (item.Length > oneWord.Length)
                    oneWord = item;                
            }
            return oneWord;
        }

        public static string LongestWord(string sen)
        {
            // Match all characters that DO NOT(^) match(\w alphanumeric characters) and \s(white space and tab) 
            // and replace them with ""
            Regex regx = new Regex(@"[^\w\s]");
            sen = regx.Replace(sen, "");
            string[] words = sen.Split(" ");
            return words.OrderByDescending(x => x.Length).First();
        }

        static void Main()
        {
            Console.WriteLine(LongestWord2(Console.ReadLine()));
        }
    }
}