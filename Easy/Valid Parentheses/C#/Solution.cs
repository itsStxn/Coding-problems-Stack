namespace Valid_Parentheses;


public class Solution {
    public bool IsValid(string s) {
			if (s.Length % 2 != 0) return false;
			Stack<char> closes = [];
			Dictionary<char, char> map = new() {
				['('] = ')',
				['['] = ']',
				['{'] = '}'
			};

			foreach (char bracket in s) {
				if (map.TryGetValue(bracket, out char close)) {
					closes.Push(close);
				} else if (closes.Count == 0 || closes.Pop() != bracket) return false;
			}
			return closes.Count == 0;
    }
}
