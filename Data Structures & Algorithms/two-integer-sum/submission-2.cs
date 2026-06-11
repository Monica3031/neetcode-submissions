public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // 1. Create our "Guest List"
        Dictionary<int, int> seenNumbers = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            // 2. Figure out who we are looking for
            int complement = target - nums[i];

            // 3. Check if that person is already on the list
            if (seenNumbers.ContainsKey(complement)) {
                // Return the partner's arrival number and current arrival number
                return new int[] { seenNumbers[complement], i };
            }

            // 4. If not found, add current person to the list
            seenNumbers[nums[i]] = i;
        }
        return new int[] { -1, -1 };
    }
}