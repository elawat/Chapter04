using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch04_ManipulatingText
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = "Jawor";
            WriteLine($"{city} is {city.Length} characters long");
            char first = city[0];
            WriteLine($"First character is {city[0]}"); // string is array of characters
            string cities = "Irkuck,Moskwa,Omsk,Perm";
            string[] citiesArray = cities.Split(','); //split
            foreach (string item in citiesArray)
            {
                WriteLine(item);
            }
            string fullname = "Marc Chagall";
            int space = fullname.IndexOf(' '); // indexof
            string firstname = fullname.Substring(0, space);
            string lastname = fullname.Substring(space + 1);
            WriteLine($"{lastname}, {firstname}");
            string company = "Abecadlo";
            bool startswithA = company.StartsWith("A");
            bool containsN = company.Contains("N");
            WriteLine($"{company} start with A {startswithA} and contains N {containsN}");
        }
    }
}
