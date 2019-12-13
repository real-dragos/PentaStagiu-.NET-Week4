using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardLibrary
{
    public class Person
    {
        public const double DaysPerYear = 365.2425;
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDate { get; private set; }


        public string FullName
        {
            get
            {
                return $"{this.FirstName} {this.LastName}";
            }
        }
        public int Age {
            get
            {
                return Convert.ToInt32(Math.Floor((DateTime.Now - BirthDate).TotalDays / 364.2425));
            }
        }

        public Person() : this("","",DateTime.MinValue) { }

        public Person(string firstName, string lastName, DateTime birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
        }

        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append($"Full Name: {this.FullName}\n");
            strBuilder.Append($"Age: {this.Age}\n");
            return strBuilder.ToString();
        }
    }
}
