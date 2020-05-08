using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //string array with user selection of index
        string[] nameArray = { "Frodo", "Samwise", "Merry", "Pippin", "Aragorn", "Legolas", "Gimli", "Boromir", "Gandalf" };
        int userSelection = -1;  //trigger while loop entry
        while (userSelection < 0 || userSelection > 8)
        {
            Console.WriteLine("Please select an index number (0-8) to display the name at that index.");
            userSelection = Convert.ToInt32(Console.ReadLine());
            if (userSelection < 0 || userSelection > 8)
            {
                Console.WriteLine("There is no index " + userSelection + " in the sample array.");
            }
        }
        Console.WriteLine("The name at that index is: " + nameArray[userSelection]);

        //integer array with user selection of index
        int[] numberArray = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
        userSelection = -1;  //trigger while loop entry
        while (userSelection < 0 || userSelection > 9)
        {
            Console.WriteLine("Please select an index number (0-9) to display the number at that index.");
            userSelection = Convert.ToInt32(Console.ReadLine());
            if (userSelection < 0 || userSelection > 9)
            {
                Console.WriteLine("There is no index " + userSelection + " in the sample array.");
            }
        }
        Console.WriteLine("The number at that index is: " + numberArray[userSelection]);
        
        //List of strings
        List<string> nameList = new List<string>() { "Frodo", "Samwise", "Merry", "Pippin", "Aragorn", "Legolas", "Gimli", "Boromir", "Gandalf" };
        userSelection = -1;  //trigger while loop entry
        while (userSelection < 0 || userSelection > 8)
        {
            Console.WriteLine("Please select an index number (0-8) to display the name at that index.");
            userSelection = Convert.ToInt32(Console.ReadLine());
            if (userSelection < 0 || userSelection > 8)
            {
                Console.WriteLine("There is no index " + userSelection + " in the sample list.");
            }
        }
        Console.WriteLine("The name at that index is: " + nameList[userSelection]);

        Console.ReadLine();
        //
    }

}
