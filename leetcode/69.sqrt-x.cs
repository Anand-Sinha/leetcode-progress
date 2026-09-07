/*
 * @lc app=leetcode id=69 lang=csharp
 *
 * [69] Sqrt(x)
 *
 * https://leetcode.com/problems/sqrtx/description/
 *
 * algorithms
 * Easy (42.25%)
 * Likes:    9949
 * Dislikes: 4654
 * Total Accepted:    3.4M
 * Total Submissions: 8.1M
 * Testcase Example:  '4'
 *
 * Given a non-negative integer x, return the square root of x rounded down to
 * the nearest integer. The returned integer should be non-negative as well.
 * 
 * You must not use any built-in exponent function or operator.
 * 
 * 
 * For example, do not use pow(x, 0.5) in c++ or x ** 0.5 in python.
 * 
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: x = 4
 * Output: 2
 * Explanation: The square root of 4 is 2, so we return 2.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: x = 8
 * Output: 2
 * Explanation: The square root of 8 is 2.82842..., and since we round it down
 * to the nearest integer, 2 is returned.
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 0 <= x <= 2^31 - 1
 * 
 * 
 */

// @lc code=start
public class Solution {
    public int MySqrt(int x) {
        if (x == 0 || x == 1)
            return x;
        int l = 0, r = x, minRoot = -1;
        while (l <= r)
        {
            int mid = l + (r-l)/2;
            long result = (long)mid * (long)mid;
            if (result == (long)x)
            {
                return mid;
            }
            else if (result > (long)x)
            {
                r = mid-1;
            } else
            {
                l = mid + 1;
                minRoot = mid;
            }
        }
        return minRoot;
    }
}
// @lc code=end

