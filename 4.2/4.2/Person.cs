using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    internal class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Pesel { get; set; }
        public void SetFirstName(string firstName)
        {
            Firstname = firstName;
        }
        public void SetLastName(string lastName)
        {
            Lastname =   lastName;
        }
        public void SetLastName(string pesel)
        {
            Pesel = pesel;
        }
    public int GetAge()
        {
            int year = int.Parse(Pesel.Substring(0, 2));
            int month = int.Parse(Pesel.Substring(2, 4));
            int day = int.Parse(Pesel.Substring(4, 6));
            int currentYear = DateTime.Now.Year;
            int age = currentYear - 1900 + year);

            return age;
        }
        public string GetGender()
        { 
        }
    }
}
