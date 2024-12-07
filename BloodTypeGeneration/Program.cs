using System;
using System.Collections.Generic;

namespace BloodTypeGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter father's blood type (A, B, AB, O): ");
            string fatherBloodType = Console.ReadLine().ToUpper();

            Console.WriteLine("Enter mother's blood type (A, B, AB, O): ");
            string motherBloodType = Console.ReadLine().ToUpper();

            // Validate blood types
            if (!IsValidBloodType(fatherBloodType) || !IsValidBloodType(motherBloodType))
            {
                Console.WriteLine("Invalid blood type entered. Please use A, B, AB, or O.");
                return;
            }

            // Generate possible blood types for the child
            List<string> childBloodTypes = GetChildBloodTypes(fatherBloodType, motherBloodType);

            Console.WriteLine($"Possible blood types for the child:");
            foreach (var bloodType in childBloodTypes)
            {
                Console.WriteLine(bloodType);
            }
        }

        static bool IsValidBloodType(string bloodType)
        {
            return bloodType == "A" || bloodType == "B" || bloodType == "AB" || bloodType == "O";
        }

        static List<string> GetChildBloodTypes(string fatherBloodType, string motherBloodType)
        {
            var bloodTypeCombinations = new Dictionary<(string, string), List<string>>
            {
                { ("A", "A"), new List<string> { "A", "O" } },
                { ("A", "B"), new List<string> { "A", "B", "AB", "O" } },
                { ("A", "AB"), new List<string> { "A", "B", "AB" } },
                { ("A", "O"), new List<string> { "A", "O" } },
                { ("B", "B"), new List<string> { "B", "O" } },
                { ("B", "AB"), new List<string> { "A", "B", "AB" } },
                { ("B", "O"), new List<string> { "B", "O" } },
                { ("AB", "AB"), new List<string> { "A", "B", "AB" } },
                { ("AB", "O"), new List<string> { "A", "B" } },
                { ("O", "O"), new List<string> { "O" } }
            };

            // Find combinations for both orders
            var results = new HashSet<string>();
            if (bloodTypeCombinations.ContainsKey((fatherBloodType, motherBloodType)))
                results.UnionWith(bloodTypeCombinations[(fatherBloodType, motherBloodType)]);
            if (bloodTypeCombinations.ContainsKey((motherBloodType, fatherBloodType)))
                results.UnionWith(bloodTypeCombinations[(motherBloodType, fatherBloodType)]);

            return new List<string>(results);
        }
    }
}