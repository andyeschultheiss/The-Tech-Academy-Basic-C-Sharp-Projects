using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_and_Methods_more_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer and I will divide it by 2:");
            int inputNum = Convert.ToInt32(Console.ReadLine());
            int outputNum;
            mathOps obj = new mathOps();
            obj.divideByTwo(inputNum, out outputNum);
            Console.WriteLine("{0} divided by 2 equals: {1}", inputNum, outputNum);

            Console.WriteLine("Now, please enter any number and I will divide it by 2:");
            double inputDouble = Convert.ToDouble(Console.ReadLine());
            double outputDouble;
            obj.divideByTwo(inputDouble, out outputDouble);
            Console.WriteLine("{0} divided by 2 equals: {1}", inputDouble, outputDouble);

            Console.WriteLine("Now we will explore the hailstone sequence. You will select a positive integer,");
            Console.WriteLine("which specifies a starting point for the sequence.");
            Console.WriteLine("The hailstone sequence either divides the number by 2 if it is even, ");
            Console.WriteLine("or multiplies by 3 and adds 1 if it is odd, for each iteration, until 1 is reached.");
            Console.WriteLine("Please enter the integer you wish to start at: ");
            int startNum = Convert.ToInt32(Console.ReadLine());
            int stepsTaken;

            int finalValue = mathOps.hailstone_seq(startNum, out stepsTaken);

            Console.WriteLine("The sequence reached {0} in {1} steps. Goodbye!", finalValue, stepsTaken);
            Console.ReadLine();
            
        }
    }
}
