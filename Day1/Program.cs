using System;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Literals
            // Number, Words, Decision, Date & Time

            // Numbers
            // Integer, Decimal, Real, Rational, Prime
            // Constant, Variable

            // Name
            // Variable Declaration
            string name = "Ko Aye"; // Ko Aye (string literal)
            name = "Ko Phyu";       // Ko Phyu

            char vowel = 'e';       // char literal

            Console.WriteLine(name);

            // byte, sbyte
            // short, ushort
            // int, uint (32 bits)
            // long, ulong (64 bits)

            byte age = 20;
            byte day = 24;

            Console.WriteLine(age);
            Console.WriteLine(day);

            // double, float, decimal
            double dou = 10.123;
            float flo = 10.123f;
            decimal dec = 10.123m; // 128 bits

            Console.WriteLine(dou);
            Console.WriteLine(flo);
            Console.WriteLine(dec);

            string nm = "abcdd";

            // Null values
            string mystr = null;
            object myobj = null;

            // Boolean values
            bool bo = true;
            bool b = false;
            bool c = false;
            bool d = false;

            Console.WriteLine(bo);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            // DateTime
            DateTime today = DateTime.Now.Date;
            Console.WriteLine(today.ToString("MM/dd/yyyy"));

            // sizeof for decimal
            Console.WriteLine("Decimal = " + sizeof(decimal) + " bytes"); // 16
        }
    }
}