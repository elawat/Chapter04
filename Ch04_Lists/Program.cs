using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch04_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var cities = new List<string>(); //<> generics - makes collection strongly types
            cities.Add("Moskwa");
            cities.Add("Omsk");
            cities.Add("Irkuck");
            WriteLine("Initial Cities");
            foreach (string city in cities)
            {
                WriteLine($"{city}");
            }
            WriteLine($"The first city is {cities[0]}.");
            WriteLine($"The last city is {cities[cities.Count - 1]}");
            cities.Insert(0, "Perm");
            WriteLine("After inserting Perm at index 0");
            foreach (string city in cities)
            {
                WriteLine($"{city}");
            }
            cities.RemoveAt(1);
            cities.Remove("Omsk");
            WriteLine("After removing two cities");
            foreach (string city in cities)
            {
                WriteLine($"{city}");
            }


        }
    }
}
