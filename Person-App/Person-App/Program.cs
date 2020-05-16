using System;
using System.Collections.Generic;
using System.Text;

namespace Person_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee sampleEmployee = new Employee();
            sampleEmployee.FirstName = "Sample";
            sampleEmployee.LastName = "Student";
            sampleEmployee.Id = 100;
            sampleEmployee.SayName();
            Employee employeeTwo = new Employee();
            employeeTwo.Id = 100;
            bool trueOrFalse = employeeTwo == sampleEmployee;
            Console.WriteLine("sampleEmployee and employeeTwo have identical IDs: " + Convert.ToString(trueOrFalse));
            sampleEmployee.Quit();
            IQuittable quitTime = new Employee();
            
            Console.WriteLine("It's time to go...");
            quitTime.Quit();

        }
    }
}
