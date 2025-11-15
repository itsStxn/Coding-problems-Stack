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
Use a stack to determine which rectangles are can still extend in width and which not. When a previous rectangle cannot extend anymore, it means that the current one has a smaller height.

So, calculate the area and compare it with the largest one found so far. Then, update its height to the current one and push its index to the stack.

When reached the end of the array, use a negative dummy height to force all the rectangles in the stack to be compared to the largest found.

## Time Complexity - O(n)
Altough the nested loops, each element is processed a constant amount of times. An element is always pushed and popped once.

## Space Complexity - O(n)
The stack can contain at most n elements.
