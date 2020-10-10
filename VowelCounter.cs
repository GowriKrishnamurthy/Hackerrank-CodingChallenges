using System;
using System.Collections.Generic;
using System.Linq;
class MainClass
{
    // Build a list of vowels up front:
    static HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

    public static int VowelCounter1(string sentence)
    {
        return sentence.Count(c => vowels.Contains(c));        
    }

    public static int VowelCounter2(string sentence)
    {
       return sentence.Count(c => "aeiou".Contains(Char.ToLower(c)));
    }
    public static int VowelCounter3(string sentence)
    {
        int total = 0;
        for (int i = 0; i < sentence.Length; i++)
        {
            if (vowels.Contains(sentence[i]))
                total++;
        }

        return total;
    }

    static void Main()
    {
        Console.WriteLine("Enter a Sentence");
        string sentence = Console.ReadLine().ToLower();
        Console.WriteLine(VowelCounter1(sentence));
        Console.WriteLine(VowelCounter2(sentence));
        Console.WriteLine(VowelCounter3(sentence));
    }     
}
