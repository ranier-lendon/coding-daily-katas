public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var seen = new Dictionary<int, int>();
        for (int x=0; x<nums.Length; x++)
        {
            int look = target-nums[x];
            if (seen.TryGetValue(look, out int y))
            {
                return new int[] {x, y};
            }
            seen.Add(nums[x], x);
        }
        return new int[0];
    }
}