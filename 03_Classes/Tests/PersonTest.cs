using _03_Classes.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Classes.Tests
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Person person = new Person();
            person.FirstName = "Stacy";
            person.LastName = "Sanders";
            person.DateOfBirth = new DateTime(1981, 8, 12);

            Vehicle myCar = new Vehicle();
            myCar.Make = "Mazda";
            myCar.Model = "CX-5";
            // ...etc

            person.Vehicle = myCar;


            Console.WriteLine($"My name is {person.FirstName} {person.LastName} and I drive a {person.Vehicle.Make} {person.Vehicle.Model}");
            Console.WriteLine($"{person.FirstName} is {person.Age} years old.");

            Person otherPerson = new Person("Terry", "Brown", new DateTime(2000, 01, 01));

        }
    }
}
           
