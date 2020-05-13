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
            sampleEmployee.SayName();

            Console.ReadLine();
        }
    }
}
