using System;
using System.Collections.Generic;
using System.Text;

namespace Optional_Parameters_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. This program accepts one or two positive integer inputs.");
            Console.WriteLine("The first specifies a starting point for the hailstone sequence ");
            Console.WriteLine("while the second is optional, and specifies the maximum number of iterations to allow,");
            Console.WriteLine("with the default being 1.");
            Console.WriteLine("The hailstone sequence either divides the number by 2 if it is even, ");
            Console.WriteLine("or multiplies by 3 and adds 1 if it is odd, for each iteration, until 1 is reached.");
            Console.WriteLine("Please enter the integer you wish to start at: ");
            int startNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you want to perform more than one iteration? (y/n)");
            string yesNoReply = Console.ReadLine().ToUpper();
            int result = 1;
            if (yesNoReply == "Y")
            {
                Console.WriteLine("Enter the maximum number of iterations you wish to perform");
                int maxSteps = Convert.ToInt32(Console.ReadLine());
                result = mathOps.hailstone_seq(startNum, maxSteps);
            }
            else if (yesNoReply == "N")
            {
                result = mathOps.hailstone_seq(startNum);
            }
            
            Console.WriteLine("You have arrived at {0} at the end of this hailstone sequence", result);

            Console.ReadLine();

        }
    }
}
