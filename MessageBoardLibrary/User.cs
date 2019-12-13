using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardLibrary
{
    public class User : Person
    {
        public string Email { get; private set; }

        public User(string email = "") : base()
        {
            this.Email = email;
        }

        public User(Person person, string email = ""): base(person.FirstName, person.LastName, person.BirthDate)
        {
            this.Email = email;
        }

        public User(string firstName, string lastName, DateTime birthDate, string email) : base(firstName, lastName, birthDate)
        {
            this.Email = email;
        }

        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append(base.ToString());
            strBuilder.Append($"Email: {this.Email}\n");
            return strBuilder.ToString();
        }
    }
}
