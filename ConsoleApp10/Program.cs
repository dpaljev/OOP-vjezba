using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nekalista = new List<string>();

            nekalista.Add("Siječanj");
            nekalista.Add("Veljača");
            nekalista.Add("Ožujak");
            nekalista.Add("Travanj");
            nekalista.Add("Svibanj");
            nekalista.Add("Lipanj");
            nekalista.Add("Srpanj");
            nekalista.Add("Kolovoz");
            nekalista.Add("Rujan");
            nekalista.Add("Listopad");
            nekalista.Add("Studeni");
            nekalista.Add("Prosinac");

            Console.WriteLine("Unesite neki broj:");
            int a = int.Parse(Console.ReadLine());

            string b = nekalista[a - 1];
            Console.WriteLine("Odabrani mjesec je: {0}", b);

            Console.ReadKey();
        }
    }
}
