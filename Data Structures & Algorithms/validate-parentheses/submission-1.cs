public class Solution {
    public bool IsValid(string s) {
        Stack<char> iv = new Stack<char>();

        foreach (char c in s) {
            if (c == '(' || c == '{' || c == '[') {
                iv.Push(c);
            }
            else if (c == ')' || c == '}' || c == ']') {
                if (iv.Count == 0) return false;
                char top = iv.Peek();
                if ((c == ')' && top != '(') ||
                    (c == '}' && top != '{') ||
                    (c == ']' && top != '[')) {
                        return false;
                    }

                    iv.Pop();
            }
        }

        return iv.Count == 0;
    }
}