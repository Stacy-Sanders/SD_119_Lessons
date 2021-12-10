using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string yourName = "Sydney";
            string myName;

            string first = "The cars we see are ";
            string second = "BMW, Lexus, and Mercedes.";
            Console.WriteLine(first + second);
            Console.WriteLine(yourName);

            string firstName = "Jenn";
            string lastName = "Williams";

            Console.WriteLine("Her name is {0} {1}.", firstName, lastName);

            string firstNameString = "Robin";
            string lastNameString = "Holler";

            Console.WriteLine($"Her name is {firstNameString} {lastNameString}");

            Console.ReadLine();
        }
    }
}
