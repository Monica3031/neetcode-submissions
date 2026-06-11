public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int left = 0; left < nums.Length; left++) {
            for (int right = left + 1; right < nums.Length; right++) {
                int sum = nums[left] + nums[right];
                if (sum == target) return new int[] {left, right};
            }
        }
        return new int[] {-1, -1};
    }
}
