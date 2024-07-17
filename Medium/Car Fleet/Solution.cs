namespace Car_Fleet;


public class Solution {
	public int CarFleet(int target, int[] position, int[] speed) {
		Array.Sort(position, speed);
		Stack<float> fleets = [];

		for (int car = 0; car < position.Length; car++) {
			float time = (float)(target - position[car]) / speed[car];
			while (fleets.Count > 0 && time >= fleets.Peek()) {
				fleets.Pop();
			}
			fleets.Push(time);
		}

		return fleets.Count;
	}
}
