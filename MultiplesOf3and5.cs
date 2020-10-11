using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Prints the numbers from 1 to 100. 
 * But for multiples of three print "3X" instead of the number 
 * and for the multiples of five print "5X". 
 * For numbers which are multiples of both three and five print "3X5X"
 */
class MainClass
{
    static void Main()
    {
        for(int i=1; i<=30; i++)
        {
            if (i % 15 == 0)
                Console.WriteLine("3X5X");             
            else if (i % 5 == 0)
                Console.WriteLine("5X");
            else if (i % 3 == 0)
                 Console.WriteLine("3X");
            else
                Console.WriteLine(i);
        }    
    }     
}
