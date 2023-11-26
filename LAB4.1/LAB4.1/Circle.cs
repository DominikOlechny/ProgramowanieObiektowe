using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4._1
{
    internal class Circle:Shape
    {
        public override void Draw()
        {
            Console.WriteLine($"Rysuje kwadrat, o wspolzednuch X: {X}" + $", Y = {Y}, wysokosc {Height}, szerokosc {Width}");
        }
    }
}

