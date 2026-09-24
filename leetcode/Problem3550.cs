public class Solution {
    public int SmallestIndex(int[] nums) {
        int res = -1;
        
        for (int i=0; i<nums.Length; i++)
        {
            int num = nums[i];
            int sum = 0;

            while (num != 0)
            {
                int first = num % 10;
                
                num /= 10;
                sum += first;
            }
            
            if (sum == i) return i;
        }
        return res;
    }
}