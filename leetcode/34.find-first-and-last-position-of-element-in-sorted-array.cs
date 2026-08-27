/*
 * @lc app=leetcode id=34 lang=csharp
 *
 * [34] Find First and Last Position of Element in Sorted Array
 *
 * https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/description/
 *
 * algorithms
 * Medium (49.55%)
 * Likes:    23659
 * Dislikes: 659
 * Total Accepted:    3.6M
 * Total Submissions: 7.2M
 * Testcase Example:  '[5,7,7,8,8,10]\n8'
 *
 * Given an array of integers nums sorted in non-decreasing order, find the
 * starting and ending position of a given target value.
 * 
 * If target is not found in the array, return [-1, -1].
 * 
 * You must write an algorithm with O(log n) runtime complexity.
 * 
 * 
 * Example 1:
 * Input: nums = [5,7,7,8,8,10], target = 8
 * Output: [3,4]
 * Example 2:
 * Input: nums = [5,7,7,8,8,10], target = 6
 * Output: [-1,-1]
 * Example 3:
 * Input: nums = [], target = 0
 * Output: [-1,-1]
 * 
 * 
 * Constraints:
 * 
 * 
 * 0 <= nums.length <= 10^5
 * -10^9 <= nums[i] <= 10^9
 * nums is a non-decreasing array.
 * -10^9 <= target <= 10^9
 * 
 * 
 */

// @lc code=start
using System.Runtime.CompilerServices;

public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int low = 0, high = nums.Length - 1, firstOcc = -1, lastOcc = -1;
        if (nums.Length == 0)
        {
            return [-1, -1];
        } else if (nums.Length == 1)
        {
            return nums[0] == target ? [0, 0] : [-1, -1];
        }
        while (low <= high)
        {
            int mid = low + (high-low)/2;
            if (nums[mid] == target)
            {
                int n = mid;
                while (n > -1 && nums[n] == target)
                {
                    n--;
                }
                firstOcc = ++n;
                int m = mid;
                while (m < nums.Length && nums[m] == target)
                {
                    m++;
                }
                lastOcc = --m;
                break;
            } else if (nums[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return [firstOcc, lastOcc];
    }
}
// @lc code=end

