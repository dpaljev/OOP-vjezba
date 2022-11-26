using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> decimalnibrojevi = new List<decimal>();
            List<decimal> cjelibrojevi = new List<decimal>();
            Console.WriteLine("Unesite koliko brojeva zelite unjeti:");
            int n = int.Parse(Console.ReadLine());
            while (true)
            {
                if (n == 0) break;
                Console.WriteLine("Unesi broj:");
                decimal unos = decimal.Parse(Console.ReadLine());
                if (unos % 1 == 0)
                {
                    cjelibrojevi.Add(unos);
                }
                else
                {
                    decimalnibrojevi.Add(unos);
                }
            }

            foreach (int b in cjelibrojevi)
            {
                Console.WriteLine(b);
            }
            foreach (decimal b in decimalnibrojevi)
            {
                Console.WriteLine(b);
            }
            Console.ReadKey();
        }
    }
}
