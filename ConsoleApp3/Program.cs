using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
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
                if (unos > 0)
                {
                    nekalista.Add(unos);
                }


            }

            int a = nekalista.Count();
            Console.WriteLine("Najmanji clan je: {0}", a);
            Console.WriteLine("Lista ima clanove:");

            nekalista.Sort();
            foreach (int b in nekalista)
            {
                Console.WriteLine(b);
            }
            Console.ReadKey();
        }
    }
}
