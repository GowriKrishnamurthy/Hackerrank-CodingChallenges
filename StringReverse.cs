
/*
Have the function FirstReverse(str) take the str parameter being passed and return the string in reversed order. 
For example: if the input string is "Hello World and Coders" then your program should return the string sredoC dna dlroW olleH.

Examples
Input: "coderbyte"
Output: etybredoc

Input: "I Love Code"
Output: edoC evoL I
 * */
using System;
using System.Linq;

class MainClass
{
    public static string StringReverse1(string str)
    {
        str = new string(str.Reverse().ToArray());
        return str;
    }

    public static string StringReverse2(string str)
    {
        string reverse = string.Empty;
        for (int i = str.Length - 1; i >= 0; i--)
            reverse += str[i];
        
        return reverse;
    }

    static void Main()
    {
        // keep this function call here
        string val = Console.ReadLine();
        Console.WriteLine(StringReverse1(val));
        Console.WriteLine(StringReverse2(val));
    }

}