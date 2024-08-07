using Merge_Two_Sorted_Lists;

Solution task = new();
ListNode list1 = new(1, new(2, new(4, new(5))));
ListNode list2 = new(1, new(3, new(4)));

ListNode node = task.MergeTwoLists(list1, list2);
Console.WriteLine(node);
