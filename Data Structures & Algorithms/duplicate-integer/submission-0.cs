public class Solution {
    public bool hasDuplicate(int[] nums) {
        if (nums == null || nums.Length <= 1) return false;

        HashSet<int> seen = new HashSet<int>();
        foreach (int x in nums) {
            if (seen.Contains(x)) return true;
            seen.Add(x);
        }
        return false;
    }
}