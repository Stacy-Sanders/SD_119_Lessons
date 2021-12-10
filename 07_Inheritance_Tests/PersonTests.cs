using _06_Inheritance_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _07_Inheritance_Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void NameTest()
        {
            PersonTests person = new Person();
            Console.WriteLine(person.Name);
            person.SetFirstName("Terry");
            person.SetLastName("Brown");
            Console.WriteLine(person.Name);
        }
    }
}
