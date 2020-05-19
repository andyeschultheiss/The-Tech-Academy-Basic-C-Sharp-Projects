using System;

namespace Struct_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Number newNumber = new Number();
            newNumber.Amount = 3.14159m;
            Console.WriteLine(newNumber.Amount);
            Console.ReadLine();
        }

        public struct Number
        {
            public decimal Amount { get; set; }

        }
    }
}
