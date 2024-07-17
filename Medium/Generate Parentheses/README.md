# Generate Parentheses

## Description
Given `n` pairs of parentheses, write a function to generate all combinations of well-formed parentheses.

### Example 1:
`Input:` `n` = 3
`Output:` ["((()))","(()())","(())()","()(())","()()()"]

### Example 2:
`Input:` `n` = 1
`Output:` ["()"]

### Constraints:
1 <= `n` <= 8

## Strategy
Recursively generate all combinations of well-formed parentheses. 
- *Use the number of open parentheses and n to stop the generation.* 
- *Use the number of open parentheses to generate close parentheses.*

A generation is completed when its length is equal to **n * 2**.

## Time Complexity - O(Cn x n)
The number of valid combinations is a Catalan number *Cn*. Each combination will end up having *2 * n* number of parentheses. 

So, there are **Cn** combinations generated in **O(n)** time.

## Space Complexity - O(Cn x n)
The output of the function has **Cn** strings, and each of string will have *2 * n* number of parentheses, hence **O(n)** space.
