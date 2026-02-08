using Merge_Two_Sorted_Lists;

var task = new Solution();
ListNode list1 = new(1, new(2, new(4, new(5))));
ListNode list2 = new(1, new(3, new(4)));
ListNode node = task.MergeTwoLists(list1, list2);
Console.WriteLine(node);

task = new AlternativeSolution();
list1 = new(1, new(2, new(4, new(5))));
list2 = new(1, new(3, new(4)));
node = task.MergeTwoLists(list1, list2);
Console.WriteLine(node);
