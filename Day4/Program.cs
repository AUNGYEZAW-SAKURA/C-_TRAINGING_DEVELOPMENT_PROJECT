using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Collection, Loop

            // Array
            //int count = 5;
            //int[] nums = new int[count]; // Initialize an array with 5 elements (index 0 to 4)

            // Assign values to the array
            //nums[3] = 12;               // Assign value 12 to index 3
            //nums[count - 4] = 10;      // Equivalent to nums[1] = 10
            //nums[2] = 65;              // Assign value -65 to index 2
            //nums[0 * 1] = 74;           // Equivalent to nums[0] = 74
            //nums[16 / 4] = 36;         // Equivalent to nums[4] = 36

            // Print array elements
            //Console.WriteLine(nums[0]); // Output for index 0
            //Console.WriteLine(nums[1]); // Output for index 1
            //Console.WriteLine(nums[2]); // Output for index 2
            //Console.WriteLine(nums[3]); // Output for index 3
            //Console.WriteLine(nums[4]); // Output for index 4

            //int n = 0;
            //ITC:if (n < 5)
            //{
            //    Console.WriteLine(nums[n]);
            //    n++;
            ///    goto ITC;

            //}
            // Data Structure: Array
            int[] nums2 = { 12, 13, 67, 87, 94, 52, 41, 76 }; // Initialize an array
            int len = nums2.Length; // Get the length of the array

            // Loop through the array and print each element
            for (int n = 0; n < len; n++)
            {
                Console.WriteLine(nums2[n]);
            }

            Console.WriteLine(); // Print an empty line for separation

            // Data Structure: ArrayList
            ArrayList mydata = new ArrayList(); // Object instantiation

            // Add elements of different types to the ArrayList
            mydata.Add(10);               // Add an integer
            mydata.Add("sdafds");         // Add a string
            mydata.Add(10.36);            // Add a double
            mydata.Add(DateTime.Now);     // Add the current date and time
            mydata.Add('a');              // Add a character

            // Iterate through the ArrayList and print each element
            foreach (var res in mydata)
            {
                Console.WriteLine(res);
            }


        }
    }
}
