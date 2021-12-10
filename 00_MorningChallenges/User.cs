using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_MorningChallenges

    //Give the user a FirstName, LastName,
    //ID (an integer, with no setter), and BirthDate properties.

    //Create a blank constructor and a full constructor for this class.

    //Bonus: Create a method that returns the full name of the user.
    //Double Bonus: Create a method that returns the age of the user in years.
{
    public class User

        //constructors -> you can have as many as you want
        //Create a blank constructor and a full constructor for this class.
    {
        public User() { }

        public User(string firstName, string lastName, int iD, DateTime birthDate)
        {
            //class properties always on the left
            FirstName = firstName;
            LastName = lastName;
            ID = iD;
            BirthDate = birthDate;
        }


        //start w/properties first...
        //ID (an integer, with no setter), and BirthDate properties.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; }
        public DateTime BirthDate { get; set; }

        public string FullName //public string HiMyNameIs()
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public int Age
        {
            get
            {
                TimeSpan age = DateTime.Now - BirthDate;
                return Convert.ToInt32(Math.Floor(age.TotalDays / 365.24));
            }
        }

    }
}
