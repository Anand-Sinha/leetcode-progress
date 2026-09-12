/*
 * @lc app=leetcode id=875 lang=csharp
 *
 * [875] Koko Eating Bananas
 *
 * https://leetcode.com/problems/koko-eating-bananas/description/
 *
 * algorithms
 * Medium (50.44%)
 * Likes:    14258
 * Dislikes: 940
 * Total Accepted:    1.8M
 * Total Submissions: 3.6M
 * Testcase Example:  '[3,6,7,11]\n8'
 *
 * Koko loves to eat bananas. There are n piles of bananas, the i^th pile has
 * piles[i] bananas. The guards have gone and will come back in h hours.
 * 
 * Koko can decide her bananas-per-hour eating speed of k. Each hour, she
 * chooses some pile of bananas and eats k bananas from that pile. If the pile
 * has less than k bananas, she eats all of them instead and will not eat any
 * more bananas during this hour.
 * 
 * Koko likes to eat slowly but still wants to finish eating all the bananas
 * before the guards return.
 * 
 * Return the minimum integer k such that she can eat all the bananas within h
 * hours.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: piles = [3,6,7,11], h = 8
 * Output: 4
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: piles = [30,11,23,4,20], h = 5
 * Output: 30
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: piles = [30,11,23,4,20], h = 6
 * Output: 23
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= piles.length <= 10^4
 * piles.length <= h <= 10^9
 * 1 <= piles[i] <= 10^9
 * 
 * 
 */
// [4, 11, 20, 23, 30]
// @lc code=start
public class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int low = 1, high = piles.Max();
        int minNumBananas = int.MaxValue;
        while (low <= high)
        {
            int mid = low + (high - low)/2;
            long totalHours = 0;
            for (int i = 0; i < piles.Length; i++)
            {
                totalHours += (piles[i] + mid - 1)/mid;
            }
            if (totalHours <= h)
            {
                minNumBananas = int.Min(mid, minNumBananas);
                high = mid - 1;
            } else
            {
                low = mid + 1;
            }
        }
        return minNumBananas;
    }
}
// @lc code=end

