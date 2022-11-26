using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nekalista = new List<int>();
            while (true)
            {

                Console.WriteLine("Unesi element strukture:");
                int unos = int.Parse(Console.ReadLine());
                if (unos == 0) break;
                if (unos > 99 || unos < -99)
                {
                    unos = 0;
                }
                nekalista.Add(unos);


            }

            foreach (int b in nekalista)
            {
                Console.WriteLine(b);
            }
            Console.ReadKey();
        }
    }
}
