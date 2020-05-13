using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_and_Methods_more_practice
{
    class mathOps
    {
        public void divideByTwo(int inputNum, out int outputNum)
        {
            outputNum = inputNum / 2;
        }

        public void divideByTwo(double inputNum, out double outputNum)
        {
            outputNum = inputNum / 2;
        }


        public static int hailstone_seq(int inputNum, out int stepsTaken)
        {
            stepsTaken = 0;
            while (inputNum != 1)
            {
                if (inputNum % 2 == 0)  //check if even
                {
                    inputNum /= 2;
                }
                else                   //all non-even ints are odd
                {
                    inputNum = 3 * inputNum + 1;
                }
                stepsTaken++;         //increment step counter
            }
            return inputNum;
        }


    }
}
