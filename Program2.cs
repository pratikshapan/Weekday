using System;



namespace Weekday
{
    internal class Program2
    {
        public static void Main283()
        {
            double salary , year ,bonus;
          
            Console.WriteLine("Enter Salary");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Time period of service of Employee");
            year = Convert.ToInt32(Console.ReadLine());

            if (year > 5)
            {
                bonus = (salary * 0.05) + salary;
                Console.WriteLine("Net salary including bonus =" + bonus );
            }
            else 

            {
                Console.WriteLine("Net salary" + salary);

            }
        }
    }
}
