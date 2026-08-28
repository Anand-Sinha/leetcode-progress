/*
 * @lc app=leetcode id=229 lang=csharp
 *
 * [229] Majority Element II
 *
 * https://leetcode.com/problems/majority-element-ii/description/
 *
 * algorithms
 * Medium (56.71%)
 * Likes:    11208
 * Dislikes: 510
 * Total Accepted:    1.4M
 * Total Submissions: 2.4M
 * Testcase Example:  '[3,2,3]'
 *
 * Given an integer array of size n, find all elements that appear more than ⌊n
 * / 3⌋ times.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: nums = [3,2,3]
 * Output: [3]
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums = [1]
 * Output: [1]
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: nums = [1,2]
 * Output: [1,2]
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= nums.length <= 5 * 10^4
 * -10^9 <= nums[i] <= 10^9
 * 
 * 
 * 
 * Follow up: Could you solve the problem in linear time and in O(1) space?
 * 
 */

// @lc code=start
public class Solution
{
    public IList<int> MajorityElement(int[] nums)
    {
        int count1 = 0, count2 = 0;
        int? currElem1 = null, currElem2 = null;
        List<int> result = [];
        for (int i = 0; i < nums.Length; i++)
        {
            if (count1 == 0 && currElem2 != nums[i])
            {
                currElem1 = nums[i];
            }
            if (count2 == 0 && currElem1 != nums[i])
            {
                currElem2 = nums[i];
            }

            if (currElem1 != null && currElem2 != nums[i])
                count1 += currElem1 == nums[i] ? 1 : -1;
            if (currElem2 != null && currElem1 != nums[i])
                count2 += currElem2 == nums[i] ? 1 : -1;
        }
        if (currElem1 != null)
        {
            int tempCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == (int)currElem1)
                    tempCount++;
            }
            if (tempCount > nums.Length / 3)
                result.Add((int)currElem1);
        }
        if (currElem2 != null)
        {
            int tempCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == (int)currElem2)
                    tempCount++;
            }
            if (tempCount > nums.Length / 3 && currElem1 != currElem2)
                result.Add((int)currElem2);
        }


        return result;
    }
}
// @lc code=end

/*
    NOTES
    I Took hint, was not sure how to keep the two count states separate
*/