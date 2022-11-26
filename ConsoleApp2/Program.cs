using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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
                nekalista.Add(unos);


            }

            int a = nekalista.Min();
            Console.WriteLine("Najmanji clan je: {0}", a);
            nekalista.Remove(nekalista.Min());
            Console.WriteLine("Lista ima clanove:");

            nekalista.Reverse();
            foreach (int b in nekalista)
            {
                Console.WriteLine(b);
            }
            Console.ReadKey();
        }
    }
}
