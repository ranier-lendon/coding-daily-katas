// Link: https://leetcode.com/problems/median-of-two-sorted-arrays/

public class Solution 
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) 
    {
        if (nums1.Length > nums2.Length)
        {
            return FindMedianSortedArrays(nums2, nums1);
        }

        int array1Len = nums1.Length;
        int array2Len = nums2.Length;

        int low = 0;
        int high = array1Len;

        while (low <= high)
        {
            int cutA = (low+high)/2;
            int cutB = (array1Len+array2Len+1)/2 - cutA;

            int frontA = (cutA == 0) ? int.MinValue : nums1[cutA - 1];
            int backA = (cutA == array1Len) ? int.MaxValue : nums1[cutA];

            int frontB = (cutB == 0) ? int.MinValue : nums2[cutB - 1];
            int backB = (cutB == array2Len) ? int.MaxValue : nums2[cutB];

            if (frontA <= backB && frontB <= backA)
            {
                if ((array1Len+array2Len) % 2 == 0)
                {
                    return (Math.Max(frontA, frontB) + Math.Min(backA, backB)) / 2.0;
                }
                else
                {
                    return Math.Max(frontA, frontB);
                }
            }
            else if (frontA > backB)
            {
                high = cutA - 1;
            }
            else
            {
                low = cutA + 1;
            }
        }
        return 0;
    }
}