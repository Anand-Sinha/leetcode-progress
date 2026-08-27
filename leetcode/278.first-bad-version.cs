/*
 * @lc app=leetcode id=278 lang=csharp
 *
 * [278] First Bad Version
 *
 * https://leetcode.com/problems/first-bad-version/description/
 *
 * algorithms
 * Easy (47.56%)
 * Likes:    9130
 * Dislikes: 3454
 * Total Accepted:    2.2M
 * Total Submissions: 4.7M
 * Testcase Example:  '5\n4'
 *
 * You are a product manager and currently leading a team to develop a new
 * product. Unfortunately, the latest version of your product fails the quality
 * check. Since each version is developed based on the previous version, all
 * the versions after a bad version are also bad.
 * 
 * Suppose you have n versions [1, 2, ..., n] and you want to find out the
 * first bad one, which causes all the following ones to be bad.
 * 
 * You are given an API bool isBadVersion(version) which returns whether
 * version is bad. Implement a function to find the first bad version. You
 * should minimize the number of calls to the API.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: n = 5, bad = 4
 * Output: 4
 * Explanation:
 * call isBadVersion(3) -> false
 * call isBadVersion(5) -> true
 * call isBadVersion(4) -> true
 * Then 4 is the first bad version.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: n = 1, bad = 1
 * Output: 1
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= bad <= n <= 2^31 - 1
 * 
 * 
 */

// @lc code=start
/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        if (n == 0)
            return n;
        if (n == 1)
            return IsBadVersion(n) == true ? 1 : 0;
        
        int low = 0, high = n, minVersion = int.MaxValue;
        
        while (low <= high){
            int mid = low + (high-low)/2;
            if (IsBadVersion(mid)){
                minVersion = int.Min(minVersion, mid);
                high = mid - 1;
            } else
            {
                low = mid + 1;
            }
        }
        return minVersion;
    }
}
// @lc code=end

