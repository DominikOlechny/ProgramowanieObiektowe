using System.Drawing;
using System;
using System.Runtime.InteropServices;

//zadanie1();
Zadanie2();
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

//zadanie 2

static void Zadanie2()
{
    Menu();
}

static void Menu()
{
ViewMenu:
    Console.WriteLine("========== Kalkulator =================");
    Console.WriteLine("========== 1. Suma =================");
    Console.WriteLine("========== 2. Roznica =================");
    Console.WriteLine("========== 3. Iloczyn =================");
    Console.WriteLine("========== 4. Iloraz =================");
    Console.WriteLine("========== 5. Potegowanie =================");
    Console.WriteLine("========== 6. Pierwisatek z liczby =================");
    Console.WriteLine("========== 7. Funkcje trygonometryczne zadanego kata =================");
    Console.WriteLine("========== 8. Wyjscie =================");
    Console.WriteLine("Twoj wybor: ");
    int choise = Convert.ToInt32(Console.ReadLine());

    switch (choise)
    {
        case 1: Total(); break;
        case 2: Difference(); break;
        case 3: ProductNumber(); break;
        case 4: QuotienNumber(); break;
        case 5: PotentiationNumber(); break;
       case 6: SquareNumber(); break;
       case 7: Trigonometry(); break;
        case 8: Close(); break;
        default:
            Console.WriteLine("Bledy wybor, sprobuj ponowanie: ");
            goto ViewMenu;
            break;
    }
}

static void Total()
{
    double x, y, wynik;
    Console.WriteLine("Podaj a");
    x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Podaj b");
    y = Convert.ToDouble(Console.ReadLine());
    wynik = x + y;
    Console.WriteLine(wynik);
    
}

static void Difference()
{
    double x, y, wynik;
    Console.WriteLine("Podaj a");
    x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Podaj b");
    y = Convert.ToDouble(Console.ReadLine());
    wynik = x - y;
    Console.WriteLine(wynik);

}

static void ProductNumber()
{
    double x, y, wynik;
    Console.WriteLine("Podaj a");
    x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Podaj b");
    y = Convert.ToDouble(Console.ReadLine());
    wynik = x * y;
    Console.WriteLine(wynik);

}

static void QuotienNumber()
{
    double x, y, wynik;
    Console.WriteLine("Podaj a");
    x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Podaj b");
    y = Convert.ToDouble(Console.ReadLine());
    while(y == 0)
    {
        Console.WriteLine("ERROR podaj cos innego niz 0");
        y = Convert.ToDouble(Console.ReadLine());
    }
    wynik = x / y;
    Console.WriteLine(wynik);

}

static void PotentiationNumber()
{
    double x, y, wynik;
    Console.WriteLine("Podaj a");
    x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Podaj b");
    y = Convert.ToDouble(Console.ReadLine());
    wynik = Math.Pow(x, y);
    Console.WriteLine(wynik);

}

static void SquareNumber();
{
    double x, y, wynik;
    Console.WriteLine("Podaj a");
    x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Podaj b");
    y = Convert.ToDouble(Console.ReadLine());
    while (x <= || y <= 0)
    {
        Console.WriteLine("Ktoras z liczb wynosi 0 Podaj je ponownie\n");
        Console.WriteLine("Podaj a");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Podaj b");
        y = Convert.ToDouble(Console.ReadLine());
    }
    wynik = Math.Sqrt(x, y);
    Console.WriteLine(wynik);
}