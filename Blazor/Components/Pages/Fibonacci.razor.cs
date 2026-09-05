namespace Blazor.Components.Pages
{
	public partial class Fibonacci
	{
		private int n = 10;
		private List<long> fibonacciNumbers = new();

		private void Calculate()
		{
			fibonacciNumbers.Clear();

			if (n <= 0) return;

			fibonacciNumbers.Add(0);

			if (n >= 2)
			{
				fibonacciNumbers.Add(1);

				for (int i = 2; i < n; i++)
				{
					fibonacciNumbers.Add(fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2]);
				}
			}
		}
	}
}
