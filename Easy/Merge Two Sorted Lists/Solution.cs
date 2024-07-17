namespace Merge_Two_Sorted_Lists;


public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 == null) return list2;
        if (list2 == null) return list1;

        ListNode merged = list1.val < list2.val ?
            new(list1.val, MergeTwoLists(list1.next, list2)):
            new(list2.val, MergeTwoLists(list1, list2.next));

        return merged;
    }
    public ListNode MergeTwoLists_stack(ListNode list1, ListNode list2) {
        ListNode merged = new();
        ListNode current = merged;

        while (list1 != null && list2 != null) {
            if (list1.val < list2.val) {
                current.next = list1;
                list1 = list1.next;
            } else {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }
        
        current.next = list1 ?? list2;
        return merged.next;
    }
}
public class ListNode {
    public int val;
    public ListNode next;

    public ListNode(int val=0, ListNode next =null) {
        this.val = val;
        this.next = next;
    }

    public override string ToString() {
        List<int> list = [];
        ListNode node = this;
        while (node != null) {
            list.Add(node.val);
            node = node.next;
        }

        return string.Join(", ", list);
    }
}
