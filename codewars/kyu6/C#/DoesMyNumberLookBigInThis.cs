using System;

public class Kata
{
  public static bool Narcissistic(int value)
  {
    int num = value;
    int sum = 0;
    int exp = (int) Math.Floor(Math.Log10(value)) + 1;
    
    while (num != 0)
    {
      int first = num % 10;
      num /= 10;
      sum += (int) Math.Pow(first, exp);
    }
    
    return sum == value;
  }
}