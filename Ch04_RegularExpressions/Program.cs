using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static System.Console;

namespace Ch04_RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter your age");
            string input = ReadLine();
            //Regex ageChecker = new Regex(@"^\d+$");
            Regex ageChecker = new Regex(@"[0-9]{2,}$");
            if (ageChecker.IsMatch(input))
            {
                WriteLine("Thanks");
            }
            else
            {
                WriteLine($"This is not a valid age: {input}");
            }
        }
    }
}
