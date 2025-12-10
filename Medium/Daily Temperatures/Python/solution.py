from typing import List


class Solution:
	def dailyTemperatures(self, temperatures: List[int]) -> List[int]:
		n = len(temperatures)
		ans = [0]*n
		past = [0]

		for today in range(1, n):
			while past and temperatures[today] > temperatures[past[-1]]:
				day = past.pop()
				ans[day] = today - day

			past.append(today)

		return ans
