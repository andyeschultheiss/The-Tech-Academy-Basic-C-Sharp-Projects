using System;
using System.Text;

namespace String_Examples
{
    class Program
    {
        static void Main()
        {
            // Concatenate three strings
            string firstName = "Andrew";
            string middleName = "Edward";
            string lastName = "Schultheiss";
            string fullName = firstName + " " + middleName + " " + lastName;
            Console.WriteLine(fullName);

            // Uppercase a string
            string alertMsg = "This is important";
            Console.WriteLine(alertMsg.ToUpper());

            // Use StringBuilder
            StringBuilder paragraph = new StringBuilder();
            paragraph.Append("When Mr. Bilbo Baggins of Bag End announced that he would shortly be \n" +
                            "celebrating his eleventy-first birthday with a party of special magnificence, \n" +
                            "there was much talk and excitement in Hobbiton. ");
            paragraph.Append("Bilbo was very rich and very peculiar, \nand had been the wonder of the Shire" +
                            "for sixty years, ever since his remarkable disappearance and unexpected return. \n");
            paragraph.Append("The riches he had brough back from his travels had now become a local legend, \n" +
                            "and it was popularly believed, whatever the old folk might say, that the Hill at Bag End \n" +
                            "was full of tunnels stuffed with treasure.");

            Console.WriteLine(paragraph);
            Console.ReadLine();
        }
    }
}
