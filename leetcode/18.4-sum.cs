/*
 * @lc app=leetcode id=18 lang=csharp
 *
 * [18] 4Sum
 *
 * https://leetcode.com/problems/4sum/description/
 *
 * algorithms
 * Medium (41.53%)
 * Likes:    13107
 * Dislikes: 1552
 * Total Accepted:    1.9M
 * Total Submissions: 4.5M
 * Testcase Example:  '[1,0,-1,0,-2,2]\n0'
 *
 * Given an array nums of n integers, return an array of all the unique
 * quadruplets [nums[a], nums[b], nums[c], nums[d]] such that:
 * 
 * 
 * 0 <= a, b, c, d < n
 * a, b, c, and d are distinct.
 * nums[a] + nums[b] + nums[c] + nums[d] == target
 * 
 * 
 * You may return the answer in any order.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: nums = [1,0,-1,0,-2,2], target = 0
 * Output: [[-2,-1,1,2],[-2,0,0,2],[-1,0,0,1]]
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums = [2,2,2,2,2], target = 8
 * Output: [[2,2,2,2]]
 * 
 *  
 * 
 * Constraints:
 * 
 * 
 * 1 <= nums.length <= 200
 * -10^9 <= nums[i] <= 10^9
 * -10^9 <= target <= 10^9
 * 
 * 
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        Array.Sort(nums);
        List<List<int>> results = [];

        if (nums.Length < 4)
        {
            return [];
        }

        for (int i = 0; i < nums.Length - 3; i++)
        { 
            if (i > 0 && nums[i] == nums[i-1])
            {   
                continue;
            }
            for (int j = i + 1; j < nums.Length - 2; j++)
            {
                if (j > i + 1 && nums[j] == nums[j - 1])
                {   
                    continue;
                }
                int k = j+1, l = nums.Length - 1;
                while (k < l)
                {
                    if (((long)nums[i] + (long)nums[j] + (long)nums[k] + (long)nums[l]) == (long)target)
                    {
                        results.Add([nums[i], nums[j], nums[k], nums[l]]);
                        k++;
                        l--;
                        while (k < l && nums[k] == nums[k - 1]) k++;
                        while (k < l && nums[l] == nums[l + 1]) l--;
                    }
                    else if (nums[i] + nums[j] + nums[k] + nums[l] > target)
                    {
                        l--;
                    }
                    else
                    {
                        k++;
                    }
                }
            }
        }

        return results.Cast<IList<int>>().ToList();
    }
}
// @lc code=end

