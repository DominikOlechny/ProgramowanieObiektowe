using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium3
{
    internal class osoba
    {
        public string firstName { get; set; } //pole
        public string lastName { get; set; }
        public int Age { get; set; }
        public osoba() { }

        public osoba(string firstName, string lastName, int Age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.Age = Age;
        }

        public void View()
        {
            Console.WriteLine($"Imie:\t{firstName}" + $"\tNazwisko:\t{lastName}" + $"\tWiek:\t{Age}");
                
        }
        //  public string Name //wlasciwosci pola
        //  { 
        //    get { return name; } 
        // set { name = value; } 
        // }
    }
}
