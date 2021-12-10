using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_MorningChallenges
{
    [TestClass]
    public class Class_Properties
    {
        [TestMethod]
        public void Challenge_1()
        {
            User user = new User();
            user.FirstName = "Stacy";
            user.LastName = "Sanders";
            user.BirthDate = new DateTime(1981, 8, 12);

            //Console.WriteLine(user.FullName());
            //Console.WriteLine(user.Age());


            Console.WriteLine($" {user.FirstName} { user.LastName}");
            Console.WriteLine($"{user.FirstName} is {user.Age} years old.");
            Console.WriteLine($" Hello { user.FirstName} { user.LastName}");


            //User user1 = new User("Sydney", "Donato", ID, new DateTime(2005, 06, 22));

            //Console.WriteLine($"ID: {user1.ID}\n" +
            //                 $"Name: {user1.FullName()}\n" +
            //               $"BirthDate: {user1.BirthDate}\n" +
            //             $"Age: {user1.Age()}\n");
        }

    }
}
