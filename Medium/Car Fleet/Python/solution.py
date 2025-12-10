from typing import List


class Solution:
	def carFleet(self, target: int, position: List[int], speed: List[int]) -> int:
		fleet = 0
		prev_time = 0
		cars = sorted(zip(position, speed), reverse=True)

		for pos, pace in cars:
			time = (target - pos) / pace
			if time > prev_time:
				fleet += 1
				prev_time = time
			
		return fleet
