namespace Largest_Rectangle_in_Histogram;

public class Solution {
	public int LargestRectangleArea(int[] heights) {
		var lEdges = new Stack<int>();
		int n = heights.Length;
		int largest = 0;

		for (int r = 0; r <= n; r++) {
				int l = r;
				int h = r < n ? heights[r] : -1;

				while (lEdges.Count > 0 && h < heights[lEdges.Peek()]) {
					l = lEdges.Pop();
					int w = r - l;
					
					largest = Math.Max(largest, w * heights[l]);
					heights[l] = h;
				}

				lEdges.Push(l);
		}

		return largest;
	}
}
