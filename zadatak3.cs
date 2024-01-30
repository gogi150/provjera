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
            Console.WriteLine("Unesite broj n: ");
            int n = int.Parse(Console.ReadLine());

            int fibN = CalculateFibonacci(n);

            Console.WriteLine("n-ti član Fibonačijevog niza je: " + fibN);
        }

        static int CalculateFibonacci(int n)
        {
            if (n <= 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
            Console.ReadLine();
        }
    }
        
    }