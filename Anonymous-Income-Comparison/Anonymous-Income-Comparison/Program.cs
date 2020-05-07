using System;

namespace Anonymous_Income_Comparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            double PersonOneHourly = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            double PersonOneHours = Convert.ToDouble(Console.ReadLine());
            // Assuming 50 paid work weeks per year
            double PersonOneSalary = PersonOneHourly * PersonOneHours * 50;

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            double PersonTwoHourly = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            double PersonTwoHours = Convert.ToDouble(Console.ReadLine());
            // Assuming 50 paid work weeks per year
            double PersonTwoSalary = PersonTwoHourly * PersonTwoHours * 50;

            //Print and compare
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(PersonOneSalary);
            Console.WriteLine("Annual salary of Person 2");
            Console.WriteLine(PersonTwoSalary);
            Console.WriteLine("Does Person 1 make more than Person 2?");
            Console.WriteLine(Convert.ToString(PersonOneSalary > PersonTwoSalary));

            Console.ReadLine();
        }
    }
}
