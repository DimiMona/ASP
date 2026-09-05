namespace Blazor.Components.Pages
{
	public partial class Fibonacci
	{
		private int n = 10;
		private long result = 55;

		private void Calculate()
		{
			result = GetFibonacci(n);
		}

		private long GetFibonacci(int n)
		{
			if (n <= 0) return 0;
			if (n == 1) return 1;

			long a = 0, b = 1;
			for (int i = 2; i <= n; i++)
			{
				long temp = a + b;
				a = b;
				b = temp;
			}
			return b;
		}
	}
}
