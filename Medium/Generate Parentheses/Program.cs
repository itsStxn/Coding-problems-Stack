using Generate_Parentheses;

var task = new Solution();
IList<string> result = task.GenerateParenthesis(4);
Console.WriteLine(string.Join(", ", result));
