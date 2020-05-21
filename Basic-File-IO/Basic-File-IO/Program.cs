using System;
using System.IO;

namespace Basic_File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please enter a number:");
            string inputNum = Console.ReadLine();
            string filePath = @"C:\Users\public\logs\numlog.txt";
            string returnText;
            using (StreamWriter file = new StreamWriter(filePath, true))
            {
                file.WriteLine(inputNum);
            }
            using (StreamReader file = new StreamReader(filePath, true))
            {
                returnText = file.ReadToEnd().ToString();
            }

            Console.WriteLine("Number logged to: {0}", filePath);
            Console.WriteLine("File contents:");
            Console.WriteLine(returnText);

            Console.Read();
        }
    }
}
