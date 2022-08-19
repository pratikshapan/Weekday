using System;

namespace Assignment2
{
    internal class Program
    {
        public static void Main1()
        {
            
            Console.WriteLine("please enter day");
            string  weekday = Console.ReadLine().ToUpper();

            if (weekday == "SUNDAY" || weekday == "SATURDAY")
            {   

                Console.WriteLine("This is a Weekend");
            }
            else if (weekday == "MONDAY" || weekday == "TUESDAY" || weekday == "WEDNESDAY" || weekday == "THURSDAY" 
                || weekday == "FRIDAY")
            { 
                Console.WriteLine("This is  a Weekday.");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }


    }
}

