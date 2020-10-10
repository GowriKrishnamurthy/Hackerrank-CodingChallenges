using System;

/*
Have the function FirstFactorial(num) take the num parameter being passed and return the factorial of it.
For example: if num = 4, then your program should return (4 * 3 * 2 * 1) = 24. 
For the test cases, the range will be between 1 and 18 and the input will always be an integer.
 * */
namespace CodingChallenges
{
    class MainClass
    {
        public static int Factorial1(int num)
        {
            if (num == 1)
                return 1;
            else
                return num * Factorial1(num - 1);
        }
        public static int Factorial2(int num)
        {
            for (int i = num - 1; i > 0; i--)
                num = num * i;
         
            return num;
        }

        static void Main()
        {
            int.TryParse(Console.ReadLine(), out int num);
            Console.WriteLine(Factorial2(num));
        }
    }
}