/*
 * @lc app=leetcode id=152 lang=csharp
 *
 * [152] Maximum Product Subarray
 *
 * https://leetcode.com/problems/maximum-product-subarray/description/
 *
 * algorithms
 * Medium (36.95%)
 * Likes:    20795
 * Dislikes: 844
 * Total Accepted:    2.2M
 * Total Submissions: 5.9M
 * Testcase Example:  '[2,3,-2,4]'
 *
 * Given an integer array nums, find a subarray that has the largest product,
 * and return the product.
 * 
 * The test cases are generated so that the answer will fit in a 32-bit
 * integer.
 * 
 * Note that the product of an array with a single element is the value of that
 * element.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: nums = [2,3,-2,4]
 * Output: 6
 * Explanation: [2,3] has the largest product 6.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums = [-2,0,-1]
 * Output: 0
 * Explanation: The result cannot be 2, because [-2,-1] is not a subarray.
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= nums.length <= 2 * 10^4
 * -10 <= nums[i] <= 10
 * The product of any subarray of nums is guaranteed to fit in a 32-bit
 * integer.
 * 
 * 
 */

// @lc code=start
public class Solution {
    public int MaxProduct(int[] nums) {
       int currMax = nums[0], currMin = nums[0], result = nums[0];
       if (nums.Length == 1)
        return nums[0];

       for (int i = 1; i < nums.Length; i++)
        {
            int tempMax = currMax * nums[i];
            int tempMin = currMin * nums[i];

            currMax = int.Max(int.Max(tempMax, tempMin), nums[i]);
            currMin = int.Min(int.Min(tempMax, tempMin), nums[i]);
            result = int.Max(currMax, result);
        }

        return result;
    }
}
// @lc code=end

