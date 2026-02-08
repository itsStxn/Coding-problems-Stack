using System;

namespace Merge_Two_Sorted_Lists;

public class AlternativeSolution : Solution {
	override public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
		if (list1 == null) return list2;
		if (list2 == null) return list1;

		ListNode merged = list1.val < list2.val ?
				new(list1.val, MergeTwoLists(list1.next, list2)):
				new(list2.val, MergeTwoLists(list1, list2.next));

		return merged;
	}
}
