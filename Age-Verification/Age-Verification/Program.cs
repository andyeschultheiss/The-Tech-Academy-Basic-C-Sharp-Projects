using System;
using System.Linq.Expressions;

namespace Age_Verification
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string RangeErrorMessage = "Please enter a positive integer greater than zero for age value.";
            string TypeErrorMessage = "Please enter your age in positive integer format, greater than zero";
            try
            {
                DateTime todaysDate = new DateTime();
                todaysDate = DateTime.Now;
                Console.WriteLine("Hello! Today's date and current time are: {0}", todaysDate.ToString());
                Console.WriteLine("Please input your age in years:");
                
                int userAge;
                bool validInput = int.TryParse(Console.ReadLine(), out userAge);
                if (!validInput)
                {
                    throw new TypeException();
                }
                if (userAge <= 0)
                {
                    throw new RangeException();
                }
                
                DateTime birthDate = new DateTime();
                birthDate = todaysDate.AddYears(-userAge);
                int yearBorn = birthDate.Year;

                Console.WriteLine("You were born before today's date in {0} or after this date in {1}", yearBorn.ToString(), (yearBorn-1).ToString());
                Console.Read();
            }
            catch (RangeException)
            {
                Console.WriteLine(RangeErrorMessage);
                Console.Read();
            }
            catch (TypeException)
            {
                Console.WriteLine(TypeErrorMessage);
                Console.Read();
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred. Please contact your system administrator for assistance.");
                Console.Read();
            }
        }
    }
}
