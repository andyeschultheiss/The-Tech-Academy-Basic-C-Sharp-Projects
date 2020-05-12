using System;
using System.Collections.Generic;

namespace Exception_Handling_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int> {1, 1, 2, 3, 5, 8, 13, 21, 34, 55};
            try
            {
                Console.WriteLine("Please enter an integer:");
                int inputNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Integer division of the first ten members of the Fibonacci sequence by " + inputNum + " yields:");
                foreach (int num in numList)
                {
                    Console.WriteLine(Convert.ToString(num / inputNum));
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Integer division attempted.");
                Console.ReadLine();
            }
            
        }
    }
}
