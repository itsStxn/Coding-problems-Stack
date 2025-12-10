from typing import List


class Solution:
	def evalRPN(self, tokens: List[str]) -> int:
		nums = []
		for t in tokens:
			if t == '+':
				x2, x1 = nums.pop(), nums.pop()
				nums.append(x1 + x2)
			elif t == '-':
				x2, x1 = nums.pop(), nums.pop()
				nums.append(x1 - x2)
			elif t == '*':
				x2, x1 = nums.pop(), nums.pop()
				nums.append(x1 * x2)
			elif t == '/':
				x2, x1 = nums.pop(), nums.pop()
				nums.append(int(x1 / x2))
			else:
				nums.append(int(t))
		return nums[0]
