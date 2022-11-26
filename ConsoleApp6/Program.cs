using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nekalista = new List<int>();
            int a = 0;
            while (true)
            {

                Console.WriteLine("Unesi element strukture:");
                int unos = int.Parse(Console.ReadLine());
                if (unos < 10 && unos > -10) break;
                nekalista.Add(unos);
            }

            foreach (int b in nekalista)
            {
                Console.WriteLine(b);
                if (b % 5 == 0)
                {
                    a += 1;
                }
            }
            Console.WriteLine("Brojeva djeljivo sa 5 je: {0}", a);
            Console.ReadKey();
        }
    }
}
