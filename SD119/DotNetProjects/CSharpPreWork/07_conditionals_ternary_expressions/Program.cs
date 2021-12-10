using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_conditionals_ternary_expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;

            if (number == 7)
                Console.WriteLine("The number is 7.");
            else
                Console.WriteLine("The number is not 7.");

            string response = ((number == 7) ? "The number is 7." : "The number is not 7.");
            
            Console.WriteLine(response);

            Console.ReadLine();
        }
    }
}
