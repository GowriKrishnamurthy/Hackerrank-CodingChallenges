/*
 * Have the function BracketMatcher(str) take the str parameter being passed and return 1 if the brackets are correctly matched 
 * and each one is accounted for. Otherwise return 0. 
 * For example: if str is "(hello (world))", then the output should be 1, 
 * but if str is "((hello (world))" the the output should be 0 because the brackets do not correctly match up.
 * Only "(" and ")" will be used as brackets. If str contains no brackets return 1.
*/
using System;
using System.Collections;
using System.Linq;

class MainClass
{
    public static string BracketMatcher1(string str)
    {
        Stack brackets = new Stack();
        foreach (var c in str)
        {
            if (c.Equals('('))
                brackets.Push(c);
            else if (c.Equals(')'))
            {
                if (brackets.Count == 0)
                    return "0";

                brackets.Pop();
            }
        }
        return brackets.Count == 0 ? "1" : "0";
    }
    public static string BracketMatcher2(string str)
    {
        int pCount = 0;
        foreach (var c in str)
        {
            if (c == '(') pCount++;
            if (c == ')') pCount--;
            if (pCount < 0) return "0";
        }

        return (pCount == 0) ? "1" : "0";

    }
    static void Main()
    {     
        Console.WriteLine(BracketMatcher1(Console.ReadLine()));
    }
}
