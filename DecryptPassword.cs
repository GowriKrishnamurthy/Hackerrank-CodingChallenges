using System;
using System.Collections.Generic;
using System.Text;

class Solution
{
    public static string decryptPassword(string s)
    {
        StringBuilder password = new StringBuilder();
        Stack<char> numbers = new Stack<char>();
        char[] pwd = s.ToCharArray();

        for (int i = 0; i < pwd.Length; i++)
        {   
            if (Char.IsUpper(pwd[i])
                && (i != pwd.Length-1)
                && Char.IsLower(pwd[i+1]) && pwd[i+2].Equals('*'))
            {
                password.Append(pwd[i + 1].ToString());
                password.Append(pwd[i].ToString());
                i = i + 2;
                continue;
            }
            if (Char.IsDigit(pwd[i]))
            {
                if (pwd[i].Equals('0'))
                {
                    if (numbers.Count > 0)
                        password.Append(numbers.Pop());
                }
                else
                    numbers.Push(pwd[i]);
             }
            else
                password.Append(pwd[i].ToString());

        }
        return password.ToString();
    }

    public static void Main(string[] args)
    {
        
//        Console.WriteLine(decryptPassword("pTo*Ta*O")); //poTaTO
  //       Console.WriteLine(decryptPassword("1Bl*Kg*u0")); //lBgKu1
        Console.WriteLine(decryptPassword("51Pa*0Lp*0e")); //aP1pL5e
    }
}
