using Evaluate_Reverse_Polish_Notation;

var solution = new Solution();

Console.WriteLine(solution.EvalRPN(["2", "1", "+", "3", "*"]));
Console.WriteLine(solution.EvalRPN(["4", "13", "5", "/", "+"]));
Console.WriteLine(solution.EvalRPN(["10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+"]));
