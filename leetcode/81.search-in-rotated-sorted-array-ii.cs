/*
 * @lc app=leetcode id=81 lang=csharp
 *
 * [81] Search in Rotated Sorted Array II
 *
 * https://leetcode.com/problems/search-in-rotated-sorted-array-ii/description/
 *
 * algorithms
 * Medium (40.48%)
 * Likes:    9861
 * Dislikes: 1135
 * Total Accepted:    1.4M
 * Total Submissions: 3.4M
 * Testcase Example:  '[2,5,6,0,0,1,2]\n0'
 *
 * There is an integer array nums sorted in non-decreasing order (not
 * necessarily with distinct values).
 * 
 * Before being passed to your function, nums is rotated at an unknown pivot
 * index k (0 <= k < nums.length) such that the resulting array is [nums[k],
 * nums[k+1], ..., nums[n-1], nums[0], nums[1], ..., nums[k-1]] (0-indexed).
 * For example, [0,1,2,4,4,4,5,6,6,7] might be rotated at pivot index 5 and
 * become [4,5,6,6,7,0,1,2,4,4].
 * 
 * Given the array nums after the rotation and an integer target, return true
 * if target is in nums, or false if it is not in nums.
 * 
 * You must decrease the overall operation steps as much as possible.
 * 
 * 
 * Example 1:
 * Input: nums = [2,5,6,0,0,1,2], target = 0
 * Output: true
 * Example 2:
 * Input: nums = [2,5,6,0,0,1,2], target = 3
 * Output: false
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= nums.length <= 5000
 * -10^4 <= nums[i] <= 10^4
 * nums is guaranteed to be rotated at some pivot.
 * -10^4 <= target <= 10^4
 * 
 * 
 * 
 * Follow up: This problem is similar to Search in Rotated Sorted Array, but
 * nums may contain duplicates. Would this affect the runtime complexity? How
 * and why?
 * 
 */

// @lc code=start
public class Solution {
    public bool Search(int[] nums, int target) {
        int l = 0, r = nums.Length - 1;
        if (nums.Length == 1)
        {
            return nums[0] == target;
        }
        while (l <= r)
        {
            int mid = l + (r-l)/2;
            if (nums[mid] == target || nums[l] == target || nums[r] == target)
                return true;
            if (nums[l] == nums[r])
            {
                l++;
                while (l<r && nums[l] == nums[l-1])
                    l++;
                r--;
                while (l<r && nums[r] == nums[r+1])
                    r--;
            }
            else if (nums[l] < nums[r])
            {
                if (target > nums[mid])
                {
                    l = mid + 1;
                    while (l<r && nums[l] == nums[l-1])
                        l++;
                } else
                {
                    r = mid - 1;
                    while (l<r && nums[r] == nums[r+1])
                        r--;
                }
            } else
            {
                if (target < nums[l] && target < nums[r] && nums[r] != nums[mid])
                {
                    l = mid + 1;
                    while (l<r && nums[l] == nums[l-1])
                        l++;
                } else
                {
                    r = mid - 1;
                    while (l<r && nums[r] == nums[r+1])
                        r--;
                }
            }
        }
        return false;
    }
}
// @lc code=end

