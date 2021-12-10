using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double Bill = 54.23;
            double Tip = 12;

            double Percentage = Tip / Bill;

            Console.WriteLine(Percentage);
            Console.WriteLine(Math.Round(Percentage, 2));
            Console.ReadLine();
        }
    }
}
