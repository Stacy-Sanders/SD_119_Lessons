using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_boolean_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            float value = 101f / 2f;
            if (value == 50f)
            {
                Console.WriteLine(true);
            }
            if (value !=  50f)
            {
                Console.WriteLine(false);
            }

            Console.WriteLine("Pick a number between 1 and 10.");

            Console.ReadLine();
        }
    }
}
