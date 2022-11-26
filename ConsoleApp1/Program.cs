using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
                if (unos == 0 ) break;
                nekalista.Add(unos);


            }
            //int duljinaListe = nekalista.Count - 1;
            //for(int i = duljinaListe; i>=0; i--)
            //{
            //    Console.WriteLine(nekalista[i]);
            //}

            nekalista.Reverse();
            foreach (int b in nekalista)
            {
                Console.WriteLine(b);
            }
            Console.ReadKey();
        }
    }
}
