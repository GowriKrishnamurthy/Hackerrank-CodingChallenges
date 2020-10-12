using System;
/*
A left rotation operation on an array shifts each of the array's elements  unit to the left. 
For example, if  left rotations are performed on array , then the array would become .

Given an array  of  integers and a number, , perform  left rotations on the array. 
Return the updated array to be printed as a single line of space-separated integers.

Function Description
Complete the function rotLeft in the editor below. It should return the resulting array of integers.

rotLeft has the following parameter(s):

An array of integers .
An integer , the number of rotations.
Input Format

The first line contains two space-separated integers  and , the size of  and the number of left rotations you must perform.
The second line contains  space-separated integers .

Constraints
Output Format
Print a single line of  space-separated integers denoting the final state of the array after performing  left rotations.

Sample Input
5 4
1 2 3 4 5

Sample Output
5 1 2 3 4

*/
class Solution
{

    // Complete the rotLeft function below.
    static int[] rotLeft(int[] a, int d)
    {
        for (int j = 0; j < d; j++)
        {
            for (int i=0;i<a.Length-1;i++)
            {
                int tmp = a[i];
                a[i] = a[i + 1];
                a[i + 1] = tmp;
            }
        }
        return a;
    }

    static void Main(string[] args)
    {
        
        string[] nd = Console.ReadLine().Split(' ');

        int n = 5; // Convert.ToInt32(nd[0]);

        int d = 4;//  Convert.ToInt32(nd[1]);

        int[] a = { 1, 2, 3, 4, 5 }; // Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        int[] result = rotLeft(a, d);

        Console.WriteLine(string.Join(" ", result));

    }
}
