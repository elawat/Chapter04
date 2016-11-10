using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Text.RegularExpressions;

namespace Ch04_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {



            do
            {
                while (!Console.KeyAvailable)
                {
                    WriteLine("The default reg exp checks for at least one digit");
                    WriteLine("Enter reg exp or press ENTER to use the default: ^[a-z]+");
                    string pattern = ReadLine();
                    if (pattern == "")
                    {
                        pattern = @"^[a-z]+";
                    }
                    Regex inputChecker = new Regex(pattern);
                    WriteLine("Enter some input: ");
                    string input = ReadLine();
                    WriteLine($"{input} matches {pattern}? {inputChecker.IsMatch(input)}");

                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);


        }
    }
}
