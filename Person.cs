using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_test
{
    internal class Person
    {
        public static string SalutationMr = "Mr.";
        public static string SalutationMs = "Ms.";

        public string FirstName;
        public string LastName;
        public string salutation;
        public Person()
        {
            FirstName = "Sameer";
            LastName = "Enjapuri";
            salutation = SalutationMr;
        }
        public Person(string firstName, string lastName, string salutation)
        {
            FirstName = firstName;
            LastName = lastName;
            this.salutation = SalutationMr;
        }
        public string getName()
        {
            return FirstName + ' ' + LastName;
        }
    }
}