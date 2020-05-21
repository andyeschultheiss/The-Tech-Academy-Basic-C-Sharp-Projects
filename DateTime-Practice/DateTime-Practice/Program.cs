using System;

namespace DateTime_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime outputTime = new DateTime();
            outputTime = DateTime.Now;
            Console.WriteLine("Hello. The current date and time is: {0}", outputTime);
            Console.WriteLine("Enter a number to see what time it will be in that number of hours:");
            double inputHours = Convert.ToDouble(Console.ReadLine());
            outputTime = outputTime.AddHours(inputHours);
            Console.WriteLine("In {0} hours, it will be:", Convert.ToString(inputHours));
            Console.WriteLine(outputTime);

            Console.Read();
        }
    }
}
