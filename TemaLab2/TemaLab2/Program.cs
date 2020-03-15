using System;
using System.Configuration;

namespace TemaLab2
{
    //    Suma/diferenta a doua numere preluate de la tastatura
    class Program
    {
        static void Main()
        {
            Automobile f = new Automobile("Audi", "Rosu", 123231312);
            string s = f.afisare();
            Console.WriteLine(s);
        }
    }
}