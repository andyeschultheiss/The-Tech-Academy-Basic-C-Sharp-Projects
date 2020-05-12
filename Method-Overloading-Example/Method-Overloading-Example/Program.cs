using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Overloading_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program demonstrates method overloading.");
            Console.WriteLine("Please enter an integer:");
            int inputNum = Convert.ToInt32(Console.ReadLine());
            int outputNum = mathOps.addTwo(inputNum);
            Console.WriteLine(inputNum + " plus 2 equals " + outputNum);

            Console.WriteLine("Now, enter a decimal number:");
            decimal decimalInput = Convert.ToDecimal(Console.ReadLine());
            outputNum = mathOps.addFour(decimalInput);
            Console.WriteLine(decimalInput + " plus 4 equals " + outputNum + " (in integer math)");

            Console.WriteLine("Now, enter a string:");
            string stringInput = Console.ReadLine();
            outputNum = mathOps.addSix(stringInput);
            Console.WriteLine(stringInput + " plus 6 equals " + outputNum);

            Console.ReadLine();
        }
    }
}
