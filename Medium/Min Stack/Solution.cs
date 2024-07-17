namespace Min_Stack;


public class MinStack {
		private int Min;
		private int Value;
		private MinStack? Below;

	public MinStack() {
		Min = int.MaxValue;
		Value = int.MaxValue;
		Below = null;
	}
	
	public void Push(int val) {
		Below = new MinStack {
			Min = Min,
			Value = Value,
			Below = Below
		};
		Min = Math.Min(val, Min);
		Value = val;
	}
	
	public void Pop() {
		Min = Below!.Min;
		Value = Below.Value;
		Below = Below.Below;
	}
	
	public int Top() {
		return Value;
	}
	
	public int GetMin() {
		return Min;
	}
}
