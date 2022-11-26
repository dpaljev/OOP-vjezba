using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nekalista = new List<int>();
            Console.WriteLine("Unesite koliko brojeva zelite unjeti:");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                while (true)
                {
                    if (n == 0) break;
                    Console.WriteLine("Unesi broj:");
                    int unos = int.Parse(Console.ReadLine());
                    if (nekalista.Contains(unos) == false)
                    {
                        nekalista.Add(unos);
                        n--;
                    }
                  
                }
                Console.WriteLine("Brojevi su: ");
                foreach (int b in nekalista)
                {
                    Console.WriteLine(b);
                }
                int c = nekalista.Max();
                Console.WriteLine("Najveci broje je: {0}", c);
                
            }
            else
            {
                Console.WriteLine("Unjeli ste broj manji od 0");
            }

            Console.ReadKey();
        }
    }
}
