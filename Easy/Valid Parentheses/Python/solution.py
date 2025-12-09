class Solution:
	def isValid(self, s: str) -> bool:
		if len(s) < 2:
			return False

		opened = {
			'(': ')', 
			'{': '}', 
			'[': ']'
		}
		to_close = []

		for par in s:
			if par in opened:
				to_close.append(opened[par])
			elif not to_close or par != to_close[-1]:
				return False
			else:
				to_close.pop()

		return not to_close
