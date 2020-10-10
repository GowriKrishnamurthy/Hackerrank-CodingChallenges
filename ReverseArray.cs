using System;

class Solution
{
    static int[] reverseArray(int[] a)
    {
        int length = a.Length;
        for (int i = 0; i < length / 2; i++)
        {
            int swap = a[i];
            a[i] = a[length - i - 1];
            a[length - i - 1] = swap;
        }
        return a;
    }

    static void Main(string[] args)
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        int[] res = reverseArray(arr);

        Console.WriteLine(string.Join(" ", res));
    }
}
