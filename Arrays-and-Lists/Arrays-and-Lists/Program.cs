using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // typically use arrays for a fixed size
        int[] numberArray = new int[5];
        numberArray[0] = 5;
        numberArray[1] = 10;
        numberArray[2] = 15;
        numberArray[3] = 20;
        numberArray[4] = 25;
        Console.WriteLine(numberArray[4]);

        int[] numberArray1 = new int[] { 1, 2, 3, 4, 5 };
        Console.WriteLine(numberArray1[2]);

        int[] numberArray2 = { 3, 6, 9, 12 };
        Console.WriteLine(numberArray2[2]);

        List<int> intList = new List<int>();
        intList.Add(1);
        intList.Add(2);
        intList.Add(3);
        intList.Add(4);
        intList.Remove(4);
        Console.WriteLine(intList[1]);

        Console.ReadLine();


    }
}
