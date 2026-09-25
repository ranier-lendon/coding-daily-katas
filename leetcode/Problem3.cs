// Link: https://leetcode.com/problems/longest-substring-without-repeating-characters/submissions/2152596635/

public class Solution 
{
    public int LengthOfLongestSubstring(string s)
    {
        var seen = new Dictionary<char, int>();
        int l = 0;
        int maxLen = 0;

        for (int r = 0; r < s.Length; r++)
        {
            char currChar = s[r];

            if(seen.ContainsKey(currChar) && seen[currChar] >=l )
            {
                l = seen[currChar] + 1;
            }

            seen[currChar] = r;
            maxLen = Math.Max(maxLen, r-l+1);
        }

        return maxLen;
    }
}