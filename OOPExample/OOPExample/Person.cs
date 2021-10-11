using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    class Person
    {
        public string FirstName { set; get; }
        public string MiddleName { set; get; }
        public string LastName { set; get; }
        public Address PresentAddress { get; set; }

        public Person(string firstName, string middleName, string lastName): this(firstName, lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public Person(string firstName, string lastName): this()
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Person()
        {

        }
        public string GetFullName()
        {
            string fullName = FirstName + " " + MiddleName + " " + LastName;
            return fullName;
        }
    }
}
