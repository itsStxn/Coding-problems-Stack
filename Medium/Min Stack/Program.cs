using Min_Stack;

var minStack = new MinStack();

minStack.Push(-2);
minStack.Push(0);
minStack.Push(-3);
Console.WriteLine(minStack.GetMin());
minStack.Pop();
Console.WriteLine(minStack.Top());
Console.WriteLine(minStack.GetMin());
