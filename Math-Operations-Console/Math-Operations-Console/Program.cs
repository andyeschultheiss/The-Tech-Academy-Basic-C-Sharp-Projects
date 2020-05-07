using System;

namespace Math_Operations_Console
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Math Operations Demo.");
            Console.WriteLine("Please input a number:");
            double inputNumber = Convert.ToDouble(Console.ReadLine());
            bool moreThanFifty = inputNumber > 50;
            Console.WriteLine("Your input number multiplied by 50 is: " + (50 * inputNumber));
            Console.WriteLine("Your input number plus 25 is: " + (25 + inputNumber));
            Console.WriteLine("Your input number divided by 12.5 is: " + (inputNumber/12.5));
            Console.WriteLine("Your input number is greater than 50: " + Convert.ToString(moreThanFifty));
            Console.WriteLine("The remainder of your input number divided by 7 is: " + (inputNumber % 7));

            Console.ReadLine();

        }
    }
}
