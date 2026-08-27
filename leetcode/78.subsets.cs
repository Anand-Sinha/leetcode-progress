/*
 * @lc app=leetcode id=78 lang=csharp
 *
 * [78] Subsets
 *
 * https://leetcode.com/problems/subsets/description/
 *
 * algorithms
 * Medium (82.75%)
 * Likes:    19467
 * Dislikes: 346
 * Total Accepted:    3.2M
 * Total Submissions: 3.9M
 * Testcase Example:  '[1,2,3]'
 *
 * Given an integer array nums of unique elements, return all possible subsets
 * (the power set).
 * 
 * The solution set must not contain duplicate subsets. Return the solution in
 * any order.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: nums = [1,2,3]
 * Output: [[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums = [0]
 * Output: [[],[0]]
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= nums.length <= 10
 * -10 <= nums[i] <= 10
 * All the numbers of nums are unique.
 * 
 * 
 */

// @lc code=start
public class Solution {
    public void Generate(int currIndex, IList<int> currList, int[] nums, IList<IList<int>> result)
    {
        if (nums.Length == currIndex)
        {
            result.Add([..currList]);
            return;
        }
        currList.Add(nums[currIndex]);
        Generate(currIndex + 1, currList, nums, result);
        currList.RemoveAt(currList.Count - 1);
        Generate(currIndex + 1, currList, nums, result);
        return;
    }
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> subsets = [];
        Generate(0, [], nums, subsets);
        return subsets;
    }
}
// @lc code=end

