// Link: https://www.codewars.com/kata/530e15517bc88ac656000716/train/csharp

using System.Text;

public class Kata
{
    public static string Rot13(string message)
    {
        var result = new StringBuilder();
        
        foreach (char c in message)
        {
            if (c >= 'a' && c <= 'z')
            {
                result.Append((char)('a' + (c - 'a' + 13) % 26));
            }
            else if (c >= 'A' && c <= 'Z')
            {
                result.Append((char)('A' + (c - 'A' + 13) % 26));
            }
            else
            {
                result.Append(c);
            }
        }
        
        return result.ToString();
    }
}