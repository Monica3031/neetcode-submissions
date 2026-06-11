public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> record = new Stack<int>();

        foreach (string op in operations) {
            if (int.TryParse(op, out int value)) {
                record.Push(value);
            }
            else if (op == "C") {
                record.Pop();
            }
            else if (op == "D") {
                record.Push(2 * record.Peek());
            }
            else if (op == "+") {
                int top = record.Pop();
                int newTop = top + record.Peek();
                record.Push(top);
                record.Push(newTop);
            }
        }
        return record.Sum();
    }
}
