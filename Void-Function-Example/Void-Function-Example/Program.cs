using System;
using System.Collections.Generic;
using System.Text;


namespace Void_Function_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer:");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another integer:");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The second number entered is:");
            mathOps.squareAndDisplay(opNum: numOne, dispNum: numTwo);

        }
    }
}
