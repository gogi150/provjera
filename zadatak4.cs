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
           
                Console.WriteLine("Unesite vrijednost stranice x:");
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine("Unesite vrijednost stranice y:");
                int y = int.Parse(Console.ReadLine());

                Console.WriteLine("Unesite vrijednost stranice z:");
                int z = int.Parse(Console.ReadLine());

                if (x > 0 && y > 0 && z > 0)
                {
                    if (x * x + y * y == z * z || x * x + z * z == y * y || y * y + z * z == x * x)
                    {
                        Console.WriteLine("DA");
                    Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("NE");
                    Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Unesene vrijednosti nisu smislene. Vrijednosti moraju biti veće od 0.");
                Console.ReadLine();
            }
         }
        
    }
}