/*
 * @lc app=leetcode id=22 lang=csharp
 *
 * [22] Generate Parentheses
 *
 * https://leetcode.com/problems/generate-parentheses/description/
 *
 * algorithms
 * Medium (79.10%)
 * Likes:    23540
 * Dislikes: 1095
 * Total Accepted:    3.1M
 * Total Submissions: 3.9M
 * Testcase Example:  '3'
 *
 * Given n pairs of parentheses, write a function to generate all combinations
 * of well-formed parentheses.
 * 
 * 
 * Example 1:
 * Input: n = 3
 * Output: ["((()))","(()())","(())()","()(())","()()()"]
 * Example 2:
 * Input: n = 1
 * Output: ["()"]
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= n <= 8
 * 
 * 
 */

// @lc code=start
public class Solution {
    public void GetString(int n, string current, List<string> values){
        if (current.Length == 2*n){
            if (current.Count(c => c == '(') == n)
            {
                values.Add(current);
            }
            return;
        }
        GetString(n, current + "(", values);
        GetString(n, current + ")", values);
        return;
    }

    public IList<string> GenerateParenthesis(int n) {
        List<string> result = [];
        GetString(n, "", result);
        return result;
    }
}
// @lc code=end

