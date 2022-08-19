using System;

namespace Weekday
{
    internal class TwoNum
    {
		public static void Main100()
		{
			int num1, num2;

			Console.WriteLine("Enter any number1");
			num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter any number2");
			num2 = Convert.ToInt32(Console.ReadLine());

			if (num1 == num2)
			{
				Console.WriteLine("number1 is same as number2");
			}
			else
			{
				Console.WriteLine(" number1 different from number2");
			}
		}
	}
}

