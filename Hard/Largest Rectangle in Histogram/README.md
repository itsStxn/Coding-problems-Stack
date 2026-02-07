# Largest Rectangle in Histogram

## Description
Given an array of integers heights representing the histogram's bar height where the width of each bar is 1, return the *area of the largest rectangle in the histogram*.

### Example 1:
***Input:*** `heights` = [2,1,5,6,2,3]  
***Output:*** 10  
***Explanation:*** 
- The above is a histogram where width of each bar is 1.
- The largest rectangle is shown in the red area, which has an area = 10 units.

### Example 2:
***Input:*** `heights` = [2,4]  
***Output:*** 4

### Constraints:
- 1 <= `heights.length` <= 10^5
- 0 <= `heights[i]` <= 10^4

## Strategy
Traverse the rectangles. Each rectangle's index can be considered to be added to a stack:

If the rectangle is greater than the previously stored rectangle:
- Just push its index to the stack.

If the rectangle is lower than the previously stored rectangle:
- Store the current rectangle, and keep popping rectangles greater than the stored one.
- Then push back to the stack the index of the last rectangle that has been popped.

## Time Complexity - O(n)
Altough the nested loops, each element is processed a constant amount of times. An element is always pushed and popped once.

## Space Complexity - O(n)
The stack can contain at most n elements.
