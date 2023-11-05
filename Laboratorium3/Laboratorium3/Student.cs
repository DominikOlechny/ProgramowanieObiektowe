using Laboratorium3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Student:osoba
{
    public string NrAlbumu { get; set; }

    public Student(string firstName, string lastName, int Age, string NrAlbumu) : base(firstName, lastName, Age)
    {
        this.NrAlbumu = NrAlbumu;
    }
     public override string? ToString()
    {
        return base.ToString() + $"\tNr Albumu: " + $"\t{NrAlbumu}";
    }
}

