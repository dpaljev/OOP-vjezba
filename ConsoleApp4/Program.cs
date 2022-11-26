using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nekalista = new List<string>();
            while (true)
            {

                Console.WriteLine("Unesite ime gosta:");
                string unos = Console.ReadLine();
                if (unos == "kraj") break;
                nekalista.Add(unos);

            }
            Console.WriteLine("Prisutni gosti su:");
            nekalista.Sort();
            foreach (string element in nekalista)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}
