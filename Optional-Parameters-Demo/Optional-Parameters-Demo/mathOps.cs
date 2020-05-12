using System;
using System.Collections.Generic;
using System.Text;

namespace Optional_Parameters_Demo
{
    class mathOps
    {
        // Function accepts an integer input and returns the
        // results of following the hailstone sequence:
        // if even, divide by two and iterate, if odd, multiply
        // by three and add one, then iterate, up to a maximum number of 
        // iterations as specified by maxSteps, the number of iterations 
        // the user will allow (default of 1)
        // Sequence iterates until 1 is reached
        public static int hailstone_seq(int inputNum, int maxSteps = 1)
        {
            int stepCounter = 0;
            while (stepCounter < maxSteps && inputNum != 1)
            {
                if (inputNum % 2 == 0)  //check if even
                {
                    inputNum /= 2;
                }
                else                   //all non-even ints are odd
                {
                    inputNum = 3 * inputNum + 1;
                }
                stepCounter++;         //increment step counter
            }

            return inputNum;
        }
    
    }
}
