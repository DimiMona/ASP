

namespace Blazor.Components.Pages
{
	public partial class Power
	{
		double number = 0;
		double powerValue = 0;
		double result = 0;
		void Calculate()
		{
			result = Math.Pow(number, powerValue);
		}
	}
}
