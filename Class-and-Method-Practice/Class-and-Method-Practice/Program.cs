using System;
using System.Collections.Generic;
using System.Text;

namespace Class_and_Method_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Please enter an integer to see the results of a few math operations performed on it.");
           
            int inputNum = Convert.ToInt32(Console.ReadLine());
            int outputNum = mathOps.addTwo(inputNum);
            Console.WriteLine(inputNum + " plus 2 equals " + outputNum);
            outputNum = mathOps.subtractFive(inputNum);
            Console.WriteLine(inputNum + " minus 5 equals " + outputNum);
            outputNum = mathOps.timesThree(inputNum);
            Console.WriteLine(inputNum + " times 3 equals " + outputNum);
            outputNum = mathOps.moduloFour(inputNum);
            Console.WriteLine("The remainder of " + inputNum + " divided by 4 is " + outputNum);

            Console.ReadLine();

        }
    }
}
