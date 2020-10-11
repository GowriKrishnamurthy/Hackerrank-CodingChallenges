using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
/*
 * There are  hourglasses in . An hourglass sum is the sum of an hourglass' values. 
 * Calculate the hourglass sum for every hourglass in , then print the maximum hourglass sum. 
 * The array will always be 6*6.
Example
-9 -9 -9 1 1 1
 0 -9 0 4 3 2
-9 -9 -9 1 2 3
 0 0 8 6 6 0
 0 0 0 -2 0 0
 0 0 1 2 4 0
The  hourglass sums are:
-63, -34, -9, 12, 
-10,   0, 28, 23, 
-27, -11, -2, 10, 
  9,  17, 25, 18
The highest hourglass sum is  from the hourglass beginning at row , column :
0 4 3
  1
8 6 6
Note: If you have already solved the Java domain's Java 2D Array challenge, you may wish to skip this challenge.
Function Description
Complete the function hourglassSum in the editor below.
hourglassSum has the following parameter(s):
int arr[6][6]: an array of integers
Returns
int: the maximum hourglass sum
Input Format
Each of the  lines of inputs  contains  space-separated integers .
Sample Input
1 1 1 0 0 0
0 1 0 0 0 0
1 1 1 0 0 0
0 0 2 4 4 0
0 0 0 2 0 0
0 0 1 2 4 0
Sample Output
19
 */
class Solution
{

    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr)
    {
        int sumMax = 0;
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (i > 3 || j > 3)
                    continue;
                int sumHourglass = FindHourglassSum(arr, i, j);

                if (sumHourglass > sumMax)
                    sumMax = sumHourglass;
            }
        }
        return sumMax;
    }

    static int FindHourglassSum(int[][] arr, int i, int j)
    {
        int sumHourglass = 0;

        for (int x = i; (x < i + 3 && x < 6); x++)
        {
            for (int y = j; (y < j + 3 && y < 6); y++)
            {
                if (x == i + 1 && y != j + 1)
                    continue;

                sumHourglass += arr[x][y];
            }
        }
        return sumHourglass;
    }
    static void Main(string[] args)
    {
        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        Console.WriteLine(result); 
    }
}
