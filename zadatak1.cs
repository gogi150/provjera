using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite niz znakova:");
            string unos = Console.ReadLine();

            string zamijenjeniZnakovi = unos.Replace(" ", "_");

            Console.WriteLine("Niz znakova s zamijenjenim razmacima:");
            Console.WriteLine(zamijenjeniZnakovi);
            Console.ReadLine();
        }
    }
}
