using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_booleans
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 100 / 2;

            if (value == 50)
            {
                Console.WriteLine(true);
            }

            Console.WriteLine("Since I'm not in the if block, I'll always display.");

            Console.ReadLine();
        }
    }
}
