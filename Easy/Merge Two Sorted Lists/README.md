# Merge Two Sorted `Lists`

## Description
You are given the heads of two sorted linked lists `list1` and `list2`.
Merge the two lists into ***one sorted list***. The list should be made by splicing together the nodes of the first two lists. Return the head of the **merged linked list**.

### Example 1:
***Input:*** `list1` = [1,2,4], `list2` = [1,3,4]  
***Output:*** [1,1,2,3,4,4]

### Example 2:
***Input:*** `list1` = [], `list2` = []  
***Output:*** []

### Example 3:
***Input:*** `list1` = [], `list2` = [0]  
***Output:*** [0]

### Constraints:
- The number of nodes in both lists is in the range [0, 50].  
- -100 <= `Node.val` <= 100  
- Both `list1` and `list2` are sorted in non-decreasing order.

## Strategy
Compare each node in the lists and add the smaller one to the result list. Continue until one of the lists is empty. Add the remaining pointer node of the non-empty list to the result list.

## Time Complexity - O(n)
The code runs until one of the lists is empty, so the runtime depends on the length of the shortest list.

## Space Complexity - O(1) or O(n)
The space complexity depends on the approach used: 
- The iterative approach uses Nno data structure variables with `n` size are used. 
- The recursive approach adds space to the call stack.
