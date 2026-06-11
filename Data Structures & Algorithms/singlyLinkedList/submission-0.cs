public class ListNode {
    public int val;
    public ListNode next;

    public ListNode(int val) {
        this.val = val;
        this.next = null;
    }
}

public class LinkedList {

    private ListNode head;
    private ListNode tail;

    public LinkedList() {
        head = new ListNode(-1);
        tail = head;
    }

    public int Get(int index) {
        ListNode curr = head.next;
        int i = 0;
        while (curr != null) {
            if (i == index) return curr.val;
            i++;
            curr = curr.next;
        }
        return -1;
    }

    public void InsertHead(int val) {
        ListNode newNode = new ListNode(val);
        newNode.next = head.next;
        head.next = newNode;

        if(newNode.next == null) {
            tail = newNode;
        }
    }

    public void InsertTail(int val) {
        tail.next = new ListNode(val);
        tail = tail.next;
    }

    public bool Remove(int index) {
        ListNode curr = head;
        int i = 0;

        while (i < index && curr != null) {
            i++;
            curr = curr.next;
        }

        if (curr != null && curr.next != null) {
            if (curr.next == tail) {
                tail = curr;
            }
            curr.next = curr.next.next;
            return true;
        }
        return false;
    }

    public List<int> GetValues() {
        List<int> values = new List<int>();
        ListNode curr = head.next;
        while (curr != null) {
            values.Add(curr.val);
            curr = curr.next;
        }
        return values;
    }
}