/*
 * @lc app=leetcode id=154 lang=csharp
 *
 * [154] Find Minimum in Rotated Sorted Array II
 *
 * https://leetcode.com/problems/find-minimum-in-rotated-sorted-array-ii/description/
 *
 * algorithms
 * Hard (46.92%)
 * Likes:    5363
 * Dislikes: 532
 * Total Accepted:    743.4K
 * Total Submissions: 1.6M
 * Testcase Example:  '[1,3,5]'
 *
 * Suppose an array of length n sorted in ascending order is rotated between 1
 * and n times. For example, the array nums = [0,1,4,4,5,6,7] might
 * become:
 * 
 * 
 * [4,5,6,7,0,1,4] if it was rotated 4 times.
 * [0,1,4,4,5,6,7] if it was rotated 7 times.
 * 
 * 
 * Notice that rotating an array [a[0], a[1], a[2], ..., a[n-1]] 1 time results
 * in the array [a[n-1], a[0], a[1], a[2], ..., a[n-2]].
 * 
 * Given the sorted rotated array nums that may contain duplicates, return the
 * minimum element of this array.
 * 
 * You must decrease the overall operation steps as much as possible.
 * 
 * 
 * Example 1:
 * Input: nums = [1,3,5]
 * Output: 1
 * Example 2:
 * Input: nums = [2,2,2,0,1]
 * Output: 0
 * 
 * 
 * Constraints:
 * 
 * 
 * n == nums.length
 * 1 <= n <= 5000
 * -5000 <= nums[i] <= 5000
 * nums is sorted and rotated between 1 and n times.
 * 
 * 
 * 
 * Follow up: This problem is similar to Find Minimum in Rotated Sorted Array,
 * but nums may contain duplicates. Would this affect the runtime complexity?
 * How and why?
 * 
 * 
 * 
 */

// @lc code=start
public class Solution {
    public int FindMin(int[] nums) {
        int size = nums.Count(), low = 0, high = size-1, min = int.MaxValue;
        if (size == 1)
        {
            return nums[0];
        }
        while (low <= high)
        {
            int mid = low + (high-low)/2;
            if (nums[low] < nums[mid] || nums[high] < nums[mid])
            {
                min = int.Min(int.Min(min, nums[low]), nums[high]);
                low = mid + 1;
            } else if (nums[mid] < nums[high])
            {
                min = int.Min(min, nums[mid]);
                high = mid - 1;
            } else if (nums[low] == nums[mid])
            {
                min = int.Min(min, nums[low]);
                low++;
            } else if (nums[high] == nums[mid])
            {
                min = int.Min(min, nums[high]);
                high--;
            }
        }
        return min;
    }
}
// @lc code=end

