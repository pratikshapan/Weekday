using System;

namespace Weekday
{
	internal class Greater5
	{
		public static void Main531()
		{
			int num1;
			Console.WriteLine("Enter any number");
			num1 = Convert.ToInt32(Console.ReadLine());

			if (num1 > 5)
			{
				Console.WriteLine(num1 + "is Greater than 5");
			}
			else
			{
				Console.WriteLine(num1 + " is Smaller than 5");
			}
		}
	}
}