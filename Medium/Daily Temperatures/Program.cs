using Daily_Temperatures;

var task = new Solution();
int[] result1 = task.DailyTemperatures([73, 74, 75, 71, 69, 72, 76, 73]);
int[] result2 = task.DailyTemperatures([30, 40, 50, 60]);
int[] result3 = task.DailyTemperatures([30, 60, 90]);
Console.WriteLine(string.Join(",", result1));
