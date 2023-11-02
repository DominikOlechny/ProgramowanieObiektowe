using System.Drawing;
using System;
using System.Runtime.InteropServices;

zadanie1();
//ZADANIE1
static void zadanie1()
{
    double a, b, c;
    Console.WriteLine("Podaj a");
    a = Convert.ToDouble(Console.ReadLine());
    while (a == 0)
    {
        Console.WriteLine("a nie moze rownac sie zero, podaj jeszcze raz");
        a = Convert.ToDouble(Console.ReadLine());

    }
        Console.WriteLine("Podaj b");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Podaj c");
        c = Convert.ToDouble((Console.ReadLine()));
    miejsce(a,b,c);

    }



static double miejsce(double a, double b, double c)
{
    double delta = (b * b - 4 * a * c);
    if (delta < 0)
    {
        Console.WriteLine("brak rozwiazania");
    }
    else if (delta >0)
    {
        double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
        double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine(x1);
        Console.WriteLine(x2);
    }
    else
    {
        double x0 = (-b) / (2 * a);
        Console.WriteLine(x0);
    }
    return 0;
}






