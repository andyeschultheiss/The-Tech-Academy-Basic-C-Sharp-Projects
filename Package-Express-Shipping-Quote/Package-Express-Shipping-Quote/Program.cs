using System;

namespace Package_Express_Shipping_Quote
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            
            Console.WriteLine("Please enter the package weight:");
            int pkgWeight = Convert.ToInt32(Console.ReadLine());
            if (pkgWeight <= 50)
            {
                Console.WriteLine("Please enter the package width:");
                int pkgWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                int pkgHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                int pkgLength = Convert.ToInt32(Console.ReadLine());
                int totalDimensions = pkgWidth + pkgHeight + pkgLength;
                if (totalDimensions <= 50)
                {
                    decimal shippingCost = pkgWeight * pkgWidth * pkgHeight * pkgLength / 100m;
                    string shippingCostString = shippingCost.ToString("C2");
                    Console.WriteLine("Your estimated total for shipping this package is: " + shippingCostString);
                    Console.WriteLine("Thank you.");
                }
                else
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a nice day.");
                }
            }
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");

            }
            Console.ReadLine();
        }
    }
}
