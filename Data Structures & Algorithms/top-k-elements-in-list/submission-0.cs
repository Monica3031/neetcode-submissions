public class Solution{
public int[] TopKFrequent(int[] nums, int k) {
    // 1. Count frequencies O(N)
    var counts = new Dictionary<int, int>();
    foreach (var n in nums) {
        counts[n] = counts.GetValueOrDefault(n) + 1;
    }

    // 2. Use a Priority Queue (Min-Heap) to track Top K O(N log K)
    // .NET 6+ PriorityQueue<Element, Priority>
    var pq = new PriorityQueue<int, int>();

    foreach (var entry in counts) {
        pq.Enqueue(entry.Key, entry.Value); // Value is the frequency (priority)
        
        // If we exceed size K, remove the one with the SMALLEST frequency
        if (pq.Count > k) {
            pq.Dequeue();
        }
    }

    // 3. Extract the winners
    int[] result = new int[k];
    for (int i = 0; i < k; i++) {
        result[i] = pq.Dequeue();
    }
    return result;
}
}