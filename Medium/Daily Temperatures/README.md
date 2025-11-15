# Daily Temperatures

## Command
Given an array of integers `temperatures` represents the daily `temperatures`, 
return an array `answer` such that `answer[i]` is the number of days you have to wait after the ith day to get a warmer temperature. 

If there is no future day for which this is possible, keep `answer[i]` == 0 instead.

### Example 1
***Input:*** `temperatures` = [73,74,75,71,69,72,76,73]  
***Output:*** [1,1,4,2,1,1,0,0]

### Example 2
***Input:*** `temperatures` = [30,40,50,60]  
***Output:*** [1,1,1,0]

### Example 3
***Input:*** `temperatures` = [30,60,90]    
***Output:*** [1,1,0] 

### Constraints
- 1 <= `temperatures`.length <= 10^5  
- 30 <= `temperatures`[i] <= 100

## Strategy
Iterate throughout the `temperatures` array and check if the previous temperature is colder. 
Remember the previous `temperatures` using a stack.

## Time complexity - O(n)
The code loops through n elements. Each iteration pushes and pops a specific index exactly once.

The pop operations may occurr more than once, but they happen once on average.

## Space complexity - O(n)
The `waitDays` array reflects the number of temperatures. 
The stack has n elements only on worst cases, which are when the temperatures never see an increment. 
