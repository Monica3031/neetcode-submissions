public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dic = new();

        foreach (string s in strs)
        {
            Span<char> count = stackalloc char[26];
            foreach (char c in s)
                count[c - 'a']++;
            
            string key = new string(count);
            if (!dic.TryGetValue(key, out var list))
            {
                list = new List<string>();
                dic[key] = list;
            }
            list.Add(s);
        }
        return dic.Values.ToList();
    }
}