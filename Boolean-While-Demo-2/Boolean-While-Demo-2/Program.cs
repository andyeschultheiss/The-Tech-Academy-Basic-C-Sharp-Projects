using System;

namespace Boolean_While_Demo_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Guess-the-Number Game!");
            int inputNum = 0;

            while (inputNum != 42)
            {
                Console.WriteLine("Please enter an integer of your choice:");
                inputNum = Convert.ToInt32(Console.ReadLine());
                if (inputNum == 42)
                {
                    Console.WriteLine("Correct! You guessed the number.");
                    break;
                }
                string suggestion = inputNum > 42 ? "Too high. Try a lower number." : "Too low. Try a greater number.";
                Console.WriteLine(suggestion);

            }

            Console.Read();
        }
    }
}
