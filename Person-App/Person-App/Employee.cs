using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Person_App
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
        public void Quit()
        {
            Console.WriteLine("Do you want to exit? (y/n)");
            char yesOrNo = Convert.ToChar(Console.ReadLine());
            if (yesOrNo == 'y')
            {
                Console.WriteLine("Goodbye!");
                System.Environment.Exit(0);
            }
            else if (yesOrNo == 'n')
            {
                Console.WriteLine("okie dokie...");
            }
        }
        public static bool operator== (Employee firstEmployee, Employee secondEmployee)
        {
            if (firstEmployee.Id == secondEmployee.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator!= (Employee firstEmployee, Employee secondEmployee)
        {
            if (firstEmployee.Id != secondEmployee.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
