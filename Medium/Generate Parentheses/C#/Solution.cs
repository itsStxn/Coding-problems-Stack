namespace Generate_Parentheses;


public class Solution {
	public IList<string> GenerateParenthesis(int n) {
		List<string> output = [];
		Generator(n, 0, 0, "", output);
		return output;
	}
	public void Generator(int n, int open, int close, string current, List<string> output) {
		if (current.Length == n * 2) {
			output.Add(current);
			return;
		}
		if (open < n) Generator(n, open + 1, close, current + '(', output);
		if (close < open) Generator(n, open, close + 1, current + ')', output);
	}
}
