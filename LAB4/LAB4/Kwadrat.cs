using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    internal class Kwadrat : IFigura
       
    {
        double a;
        public override double obwod()
        {
            return 4 * a;
        }

        public override double pole()
        {
            return a * a; ;
        }
        public void View()
        {
            Console.WriteLine("Pole: " + pole() + "obwod" + obwod());
        }
    abstract class Kwadrat : Figura
        {
            double a = 4;
            int IloscBokow = 4;
            String name = "Kwadrat"
        public Kwadrat(double a)
            {
                this.a = a;
            }
        public int IloscBokow()
            {
                return IloscBokow;
            }
        public void View()
            {
                Console.WriteLine($"Figura: {Name}, Ilosc bokow: {IloscBokow})
            }
        }
    }
}
