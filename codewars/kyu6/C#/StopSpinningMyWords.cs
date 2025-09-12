using System.Collections.Generic;
using System.Linq;
using System;

// Source: https://www.codewars.com/kata/5264d2b162488dc400000001/train/csharp
public class Kata
{
    public static string SpinWords(string sentence)
    {
        string[] words = sentence.Split(" ");
        List<string> result = new List<string>();

        foreach (string word in words)
        {
            if (word.Length > 4)
                result.Add(reverse(word));
            else
                result.Add(word);
        }
        
        return String.Join(" ", result);
    }

    public string reverse(string wrd)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}