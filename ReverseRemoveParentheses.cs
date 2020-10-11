using System;
using System.Linq;

class Solution
{
    /*
     * reverse the strings contained in each pair of matching parentheses in a given string and also remove the parentheses within the given string.
     * */
    static string ReverseRemoveParentheses(string str)
    {
        int left = str.LastIndexOf('(');

        if (left == -1) return str;        
        else
        {
            int right = str.IndexOf(')', left);

            return ReverseRemoveParentheses(
                  str.Substring(0, left)
                + new string(str.Substring(left + 1, right - left - 1).Reverse().ToArray())
                + str.Substring(right + 1)
            );
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine(ReverseRemoveParentheses("p(rq)st"));
        Console.WriteLine(ReverseRemoveParentheses("(p(rq)st)"));
        Console.WriteLine(ReverseRemoveParentheses("ab(cd(ef)gh)ij"));
    }
}
