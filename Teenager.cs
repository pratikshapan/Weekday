using System;

namespace Weekday
{
	internal class Teenager
	{
		public static void Main589()
		{
			int age;
			Console.Write("Enter your age ");
			age = Convert.ToInt32(Console.ReadLine());
			if (age >= 13 && age <= 20)
			{
				Console.WriteLine("The age is teenage");

			}
			else
			{
				Console.WriteLine("The age is not teenage");
			}
		}
	}
}
