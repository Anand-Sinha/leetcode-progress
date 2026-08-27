/*
 * @lc app=leetcode id=209 lang=csharp
 *
 * [209] Minimum Size Subarray Sum
 *
 * https://leetcode.com/problems/minimum-size-subarray-sum/description/
 *
 * algorithms
 * Medium (52.70%)
 * Likes:    14715
 * Dislikes: 549
 * Total Accepted:    2.1M
 * Total Submissions: 3.9M
 * Testcase Example:  '7\n[2,3,1,2,4,3]'
 *
 * Given an array of positive integers nums and a positive integer target,
 * return the minimal length of a subarray whose sum is greater than or equal
 * to target. If there is no such subarray, return 0 instead.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: target = 7, nums = [2,3,1,2,4,3]
 * Output: 2
 * Explanation: The subarray [4,3] has the minimal length under the problem
 * constraint.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: target = 4, nums = [1,4,4]
 * Output: 1
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: target = 11, nums = [1,1,1,1,1,1,1,1]
 * Output: 0
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= target <= 10^9
 * 1 <= nums.length <= 10^5
 * 1 <= nums[i] <= 10^4
 * 
 * 
 * 
 * Follow up: If you have figured out the O(n) solution, try coding another
 * solution of which the time complexity is O(n log(n)).
 */

// @lc code=start
public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        if (nums.Length == 0)
            return 0;
        if (nums.Length == 1)
            return nums[0] >= target ? 1 : 0;
        int left = 0, right = left + 1, currentSum = nums[left] + nums[right], minLength = nums.Length;
        if (currentSum >= target)
            return right-left;
        while (left < right)
        {  
            if (nums[left] >= target || nums[right] >= target)
            {
                return 1;
            }
            if (currentSum < target)
            { 
                if (right < nums.Length - 1)
                {
                    right++;
                    currentSum += nums[right];
                } else
                {
                    left++;
                    currentSum -= nums[left];
                }
            } else
            {
                minLength = int.Min(minLength, right-left);
                if (left < right - 1)
                {
                    left++;
                    currentSum -= nums[left];
                }
            }
        }
        return minLength;
    }
}
// @lc code=end

