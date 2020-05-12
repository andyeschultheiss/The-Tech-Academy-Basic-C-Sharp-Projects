using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Overloading_Example
{
    class mathOps
    {
        public static int addTwo(int inputInt)
        {
            return inputInt + 2;
        }

        public static int addFour(decimal inputDec)
        {
            return Convert.ToInt32(inputDec) + 4;
        }

        public static int addSix(string inputString)
        {
            return Convert.ToInt32(inputString) + 6;
        }

        public static int subtractFive(int inputInt)
        {
            return inputInt - 5;
        }
    }
}
