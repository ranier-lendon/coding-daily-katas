// Link: https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1/train/csharp

using System;
using System.Collections.Generic;

public class Kata
{
  public static int DuplicateCount(string str)
  {
      var seen = new Dictionary<char, int>();
      int duplicates = 0;
      
      foreach(char c in str.ToLower())
      {
          seen[c] = seen.ContainsKey(c) ? seen[c] + 1 : 1;
          if (seen[c] == 2)
          {
              duplicates++;
          }
      }

      return duplicates;
  }
}