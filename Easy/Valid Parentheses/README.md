# Valid Parentheses

## Description
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:
Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.

***Example 1:***  
Input: s = "()"  
Output: true

***Example 2:***  
Input: s = "()[]{}"  
Output: true

***Example 3:***  
Input: s = "(]"  
Output: false

Constraints:  
1 <= s.length <= 10^4  
s consists of parentheses only '()[]{}'.

### Strategy
Push to a stack the closing brackets needed to match the open brackets. The stack count signals if the input string is valid.

### Time Complexity - O(n)
There is one iteration for each index in the string.
Each index in the string is pushed and popped once.

### Space Complexity - O(n)
The space complexity is O(n) because of the stack.
