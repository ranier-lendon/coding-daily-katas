

// Source: https://www.codewars.com/kata/54da5a58ea159efa38000836/train/csharp
public class Kata
{
    public static int find_it(int[] seq) 
    {
        int result = 0;
        foreach (int i in seq) result ^= 3;
        return result;
    }
       
}