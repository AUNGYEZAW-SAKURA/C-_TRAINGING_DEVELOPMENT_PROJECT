using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arithmetic Operators
            // +, -, *, /, %

            // Comparison Operators
            // >, <, >=, <=, ==, !=

            // Logical Operators
            // AND (&&), OR (||), NOT (!)

            // Decision Making
            // (if-else), (switch)

            // Voting Eligibility Check

            Console.Write("Enter your nationality: ");
            string nationality = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (nationality.ToLower() == "mm" && age >= 18) // Check for Myanmar nationality and age >= 18
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }


            int marks = 85;

            if (marks >= 50)
            {
                if (marks >= 85)
                {
                    Console.WriteLine("Pass with Distinction");
                }
                else if (marks >= 65)
                {
                    Console.WriteLine("Pass with Credit");
                }
                else
                {
                    Console.WriteLine("Pass");
                }
            }
            else
            {
                Console.WriteLine("Failed");
            }


            int cardNo = 11;

            // Using switch-case for better readability and simplicity
            switch (cardNo)
            {
                case 11:
                    Console.WriteLine("Jack");
                    break;
                case 12:
                    Console.WriteLine("Queen");
                    break;
                case 13:
                    Console.WriteLine("King");
                    break;
                default:
                    Console.WriteLine("Plain Card");
                    break;
            }

            // Example for Leap Year Calculation (if that's what you're attempting)
            int daysOfMonth = 9, year = 2024;

            // Check February and Leap Year Logic
            if (daysOfMonth == 2)
            {
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    Console.WriteLine("29 Days in February (Leap Year)");
                }
                else
                {
                    Console.WriteLine("28 Days in February");
                }
            }
            else
            {
                Console.WriteLine($"{daysOfMonth} is not February");
            }






        }
    }
}
