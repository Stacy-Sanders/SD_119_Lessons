using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Conditionals
{
    [TestClass]
    public class Switch
    {
        enum WeekDay 
        { 
            Monday, 
            Tuesday, 
            Wednesday, 
            Thursday, 
            Friday, 
            Saturday, 
            Sunday
        }


        [TestMethod]
        public void SwitchCases()
        {
            int input = 200;

            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello!");
                    break;
                case 2:
                    Console.WriteLine("What are you doing?");
                    break;
                default:
                    Console.WriteLine("This is default. It will execute if no other case evaluates as true.");
                    Console.WriteLine("These are not REQUIRED, you do not need a default.");
                    break;
            }

            WeekDay today = WeekDay.Sunday;
            switch (today)
            {
                case WeekDay.Monday:
                case WeekDay.Tuesday:
                    Console.WriteLine("Yeah, it's Tuesday...");
                    break;
                case WeekDay.Wednesday:
                case WeekDay.Thursday:
                case WeekDay.Friday:
                    Console.WriteLine("Hope you are ready to work.");
                    break;
                case WeekDay.Saturday:
                    break;
                case WeekDay.Sunday:
                    Console.WriteLine("Sorry, we're closed.");
                    break;
                default:
                    break;
            }

            // Using switch statements to stack code...

            int age = 20;

            switch (age)
            {
                case 18:
                    Console.WriteLine("I bet you wish you could have a 'legal' drink.");
                    break;
                case 19:
                    Console.WriteLine("Kinda, getting closer.");
                    break;
                case 20:
                    Console.WriteLine("I bet you can taste it.");
                    break;
                case 21:
                    Console.WriteLine("Finally, got that 'legal' drink.");
                    break;
                default:
                    Console.WriteLine("If all else fails....");
                    break;
            }
        }
    }
}
                 
                    
                    
