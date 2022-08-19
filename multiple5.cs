using System;


namespace Weekday
{
    internal class multiple5
    {
        public static void Main45()
        {
            int num1;
            Console.WriteLine("Enter any number");
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 % 5 == 0)
            {
                Console.WriteLine("Multiple of 5");
            }

            else
            {
                Console.WriteLine("Not a multiple of 5");
            }
        }
    }
}

