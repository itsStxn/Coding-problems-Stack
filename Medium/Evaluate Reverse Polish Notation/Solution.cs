namespace Evaluate_Reverse_Polish_Notation;


public class Solution {
	private int Operate(string sign, int num1, int num2) {
		return sign switch {
			"+" => num1 + num2,
			"-" => num1 - num2,
			"*" => num1 * num2,
			"/" => num1 / num2,
			_ => default,
		};
	}
	public int EvalRPN(string[] tokens) {
		Stack<int> stack = [];
		foreach (string token in tokens) {
			if (!int.TryParse(token, out int num)) {
				int num1 = stack.Pop();
				int num2 = stack.Pop();
				stack.Push(Operate(token, num2, num1));
			} else stack.Push(num);
		}
		
		return stack.Pop();
	}
}
