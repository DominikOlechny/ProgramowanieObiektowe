using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_21
{
    class Licz
    {
        public double value;

        public double Dodaj(double a)
        {
            return value += a; 
        }
        private double Odejmij(double a)
        {
            return value -= a;
        }
        public void View(double a)
        {
            Console.WriteLine($"Wartosc poczatkowa {value}," +
                 $"\nwartosc dodawania {a} = {Dodaj(a)},"
                + $"\nwartowsc po odjeciu {a} = {Odejmij(a)}\n");
    }
        public Licz(double value)
        {
            this.valie;
        }
}
