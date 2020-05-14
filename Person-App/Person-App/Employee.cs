using System;
using System.Collections.Generic;
using System.Text;

namespace Person_App
{
    public class Employee : Person
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }
}
