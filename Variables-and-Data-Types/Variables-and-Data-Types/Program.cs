using System;

namespace Variables_and_Data_Types
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            Console.WriteLine("What is your favorite number?");
            int yourNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your favorite number is: " + yourNumber);
            Console.ReadLine();
        }
    }
}
