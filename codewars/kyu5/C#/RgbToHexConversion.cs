// Link: https://www.codewars.com/kata/513e08acc600c94f01000001/train/csharp

using System;

public class Kata
{
    public static string Rgb(int r, int g, int b) 
    {
        return ToHex(r) + ToHex(g) + ToHex(b);
    }

    private static string ToHex(int n) => Math.Clamp(n, 0, 255).ToString("X2");
}