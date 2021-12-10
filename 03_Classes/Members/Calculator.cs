using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes.Members
{
    public class Calculator
    {
        // classes/objects = nouns
        // properties & fields = adjectives
        // methods = verbs
        // can have both properties and methods in a class

        // Make an Add method that takes in two numbers and returns the sum
        public int Add(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        // this one returns a double
        public double Add(double numOne, double numTwo)
        {
            return (numOne + numTwo);
            // double product = numOne * numTwo;
            // return product;
        }

        // Create the following methods:
        // Multiply
        // public double Multiply(double numOne, double numTwo)
           // return numOne* numTwo;

            // Expression = some value or something that resolves a value

            // "Stacy" + "Sanders" = Stacy Sanders = expression, 5+5, user.IsAdmin && loggedIn
        // Divide (and give a decimal answer)
        // Remainder
        // Divide (and give a mixed number, like 3 1/4)

        // New method: Add All
        public double AddAll(double[] numbers)
        {
            double total = 0;
            foreach (double num in numbers)
            {
                total += num;
            }
            return total;
        }

        public double Average(double[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }

            double sum = AddAll(numbers);

            double average = sum / numbers.Length;
            return average; 

        }


        public int Multiply(int numOne, int numTwo)
        {
            int product = numOne * numTwo;
            return product;
        }

        public double Divide(double numOne, double numTwo)
        {
            double quotient = numOne / numTwo;
            return quotient;
        }

        public int Divide(int x, int y)
        {
            return x / y;
            // return numOne / numTwo;
            // public double Divide(int x, int y)
            // {
            //      double xDouble = Convert.ToDouble(x);
            //      double yDouble = (double) y; // casting (convert)
            //      return xDouble / yDouble;
            //      return x / y
            // }
            
        }
        
        public int Remainder (int x, int y)
        {
              return x % y;
        }

         public string DivideMixed(int x, int y)
          {
              int quotient = x / y;
              int numerator = Remainder(x, y);
              return $"{quotient} {numerator}/{y}";
          }
    }


}


