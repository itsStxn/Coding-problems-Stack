class MinStack:

	def __init__(self):
		self.__val = 0
		self.__min = 2**31 - 1
		self.__under: MinStack|None = None

	def push(self, val: int) -> None:
		under = self.__under

		self.__under = MinStack()
		self.__under.__val = self.__val
		self.__under.__min = self.__min
		self.__under.__under = under

		self.__min = min(val, self.__min)
		self.__val = val

	def pop(self) -> None:
		if not self.__under:
			return

		self.__val = self.__under.__val
		self.__min = self.__under.__min		
		self.__under = self.__under.__under		

	def top(self) -> int:
		return self.__val

	def getMin(self) -> int:
		return self.__min
