namespace Largest_Rectangle_in_Histogram;

public class Solution {
	public int LargestRectangleArea(int[] heights) {
		Stack<int> rects = [];
		int n = heights.Length, maxArea = 0;

		for (int i = 0; i <= n; i++) {
			int currentH = i < n ? heights[i]: -1, mostLeftRect = i; 
			while (rects.Count > 0 && currentH < heights[rects.Peek()]) {
				mostLeftRect = rects.Pop();
				int w = i - mostLeftRect;
				int h = heights[mostLeftRect];
				maxArea = Math.Max(maxArea, w * h);

				if (currentH != -1) {
					heights[mostLeftRect] = currentH;
				}
			}
			rects.Push(mostLeftRect);
		}

		return maxArea;
	}
}
