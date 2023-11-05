using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium31
{
    internal class Book
    {
        public string title;
        Person Author;
        string dataWydania;
    }
    public book(string title, Person Author, string dataWydania)
    {
        this.title = title;
        this.Author = Author;
        this.dataWydania = dataWydania; 
    }
    public void View()
    {
        Console.WriteLine($"Imie:\t{FirstName}" + $"\tNazwisko:\t{LastName}" + $"\tWiek:\t{Wiek}");
    }
}
