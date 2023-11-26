using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    abstract class Figura
    {
        //medoty abstrakcyjne
        public abstract double pole();
        public abstract double obwod();

        public void View()
        {
            Console.WriteLine("Figura ");
        }
    }
}
