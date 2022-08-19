using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekday
{
    internal class Siblings
    {
		public static void Main()
		{
			int num1, num2;

			Console.WriteLine("Enter older siblings");
			num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter younger sibiling");
			num2 = Convert.ToInt32(Console.ReadLine());

			if (num1 == 0 && num2 == 0)
			{
				Console.WriteLine("Only Child");
			}
			else if (num1 == 0 && num2 > 0)
			{
				Console.WriteLine("Older child");
			}
			

			else if (num1 > 0 && num2 == 0)
			{
				Console.WriteLine(" Younger child");
			}
			if(num1 ==num2)
            {
				Console.WriteLine(" Middle child");
			}
		}
	}
}

