public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxCount = 0;
        int currentCount = 0;

        foreach (int num in nums) {
            if (num == 1) {
                currentCount++;
            } else {
                currentCount = 0;
            }

            maxCount = Math.Max(maxCount, currentCount);
        }

        return maxCount;
    }
}