using System;

namespace Tech_Academy_Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();

            Console.WriteLine("Which page number?");
            int currentPage = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            bool needsHelp = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string posExperiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string miscFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
