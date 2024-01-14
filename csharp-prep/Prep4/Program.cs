using System;
using System.Collections.Generic;
// Import the library necessary to use lists

class Program
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int>();
        // create a variable nums that can store lists
        // then, fill that variable with a new list
        // the () are necessary whenever you make an object

        System.Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int toAdd = 1;
        while (toAdd != 0)
        {
            // read in user input
            System.Console.Write("Enter a Number: ");
            toAdd = int.Parse(Console.ReadLine());
            if (toAdd != 0) // 0 should end the program and not be appended
            {
                nums.Add(toAdd);
            }
        }

        // compute sum. make the sum a float to calculate the average later
        float sum = 0;
        foreach(int num in nums)
        {
            sum += num;
        }
        System.Console.WriteLine($"The sum is: {sum}");

        // compute average
        double avg = sum / nums.Count;
        System.Console.WriteLine($"The average is: {avg}");

        // find the biggest number in the list
        int biggest = 0;
        foreach(int num in nums)
        {
            if (num > biggest)
            {
                biggest = num;
            }
        }
        System.Console.WriteLine($"The largest number is: {biggest}");
    }
}