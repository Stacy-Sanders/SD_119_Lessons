using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes.Members
{
    public class Greeter
    {
        // field - a private variable, only used inside this class
        // usually we put a _ in front of the name to indicate this
        private Random _rng = new Random();

        // Method: (we want generic functionality so it works for any user/any name, etc)
        // 1 - access modifier - where in our code can this be accessed?
        // 2 - return type - the type of value the method returns
        // 3 - "signature" = name (of method) + parameters (input)
        // 4 - body (where all the action happens)

        // 1    2    3a       3b
        public void SayHello(string name)
        {
            // 4
            Console.WriteLine($"Hello, {name}!");
        }

        // overload - same name, but different (no) paramters (can make different versions of methods)
        public void SayHello()
        {
            Console.WriteLine("Hey, you!");
        }

        public void GetRandomGreeting()
        {
            string[] availableGreetings = new string[] { "Nice to see you!", "¡Howdy!", "Hola!", "Guten Morgen", "Bon jour!", "nuqneH" };

            int randomNumber = _rng.Next(0, availableGreetings.Length);

            // below examples do "same thing"
            string randomGreeting = availableGreetings.ElementAt(randomNumber);
            // string randomGreeting = availableGreetings[randomNumber];

            Console.WriteLine(randomGreeting);
        }


    }
}
