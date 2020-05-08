using System;

namespace Boolean_While_Demo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Guess-the-Number Game!");
            int inputNum = 0;
            do
            {
                Console.WriteLine("Please enter an integer of your choice:");
                inputNum = Convert.ToInt32(Console.ReadLine());
                if (inputNum == 7)
                {
                    Console.WriteLine("Correct! You guessed the number.");
                }
                else
                {
                    string suggestion = inputNum > 7 ? "Too high. Try a lower number." : "Too low. Try a greater number.";
                    Console.WriteLine(suggestion);
                }
            }
            while (inputNum != 7);

            Console.Read();

        }
    }
}
