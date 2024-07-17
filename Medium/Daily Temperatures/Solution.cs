namespace Daily_Temperatures;


public class Solution {
	public int[] DailyTemperatures(int[] temperatures) {
		Stack<int> stack = [];
		int [] waitDays = new int[temperatures.Length];

		for (int curr = 0; curr < temperatures.Length; curr++) {
			while (stack.Count > 0 && temperatures[curr] > temperatures[stack.Peek()]) {
				int prev = stack.Pop();
				waitDays[prev] = curr - prev;
			}
			stack.Push(curr);
		}
		
		return waitDays;
	}
}
