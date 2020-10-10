using System;
using System.Text.RegularExpressions;

/*
Determine if the string is a valid username according to the following rules:
1.The username is between 4 and 25 characters.
2.It must start with a letter.
3. It can only contain letters, numbers, and the underscore character.
4. It cannot end with an underscore character.

If the username is valid then your program should return the string true, otherwise return the string false.
*/
namespace CodingChallenges
{
    class MainClass
    {
        public static string UsernameValidation(string str)
        {
            if (str.Length > 4 && str.Length < 25
            && str.Substring(str.Length - 1, 1) != "_"
            && Regex.IsMatch(str, @"^[a-zA-Z0-9_]")
            && Regex.IsMatch(str.Substring(0, 1), @"^[a-zA-Z]"))
            {
                return "true";
            }

            return "false";
        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(UsernameValidation(Console.ReadLine()));
        }
    }
}
