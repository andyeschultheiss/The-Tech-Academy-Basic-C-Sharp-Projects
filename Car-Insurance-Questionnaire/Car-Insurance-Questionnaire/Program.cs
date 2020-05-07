using System;

namespace Car_Insurance_Questionnaire
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Car Insurance Questionnaire.");
            Console.WriteLine("Answer just 3 questions and we can tell you if you qualify for insurance.");

            Console.WriteLine("Q1. What is your age?");
            ushort customerAge = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Q2. Have you ever had a DUI? Please answer true/false");
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Q3. How many speeding tickets do you have?");
            ushort numberOfTickets = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Qualified?");
            Console.WriteLine((customerAge > 15) && !(hasDUI) && (numberOfTickets <= 3));

            Console.ReadLine();
        }
    }
}
