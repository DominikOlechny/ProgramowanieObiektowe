using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium31
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Wiek { get; set; }
        public Person() { }
        public Person(string firstName, string lastName, int Wiek)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Wiek = Wiek;
        }   
            public void View()
        { 
        }
    }
}
