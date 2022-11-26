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
            List<float> decimalnibrojevi = new List<float>();
            List<float> cjelibrojevi = new List<float>();
            Console.WriteLine("Unesite koliko brojeva zelite unjeti:");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                while (true)
                {
                    if (n == 0) break;
                    Console.WriteLine("Unesi broj:");
                    float unos = float.Parse(Console.ReadLine());
                    if ((float)unos >= 1)
                    {
                        if (unos % 1 == 0)
                        {
                            cjelibrojevi.Add(unos);
                        }
                        else
                        {
                            decimalnibrojevi.Add(unos);
                        }
                        
                    }
                    n--;
                }
                Console.WriteLine("Brojevi su: ");
                foreach (float b in cjelibrojevi)
                {
                    Console.WriteLine(b);
                }
                foreach (float b in decimalnibrojevi)
                {
                    Console.WriteLine((float)b);
                }
            }
            else
            {
                Console.WriteLine("Unjeli ste broj manji od 0");
            }
            
            Console.ReadKey();
        }
    }
}
