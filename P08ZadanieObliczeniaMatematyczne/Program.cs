using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08ZadanieObliczeniaMatematyczne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dzialanie");
            string dzialanie = Console.ReadLine();
            if (dzialanie.Contains('+'))
            {
                int liczba1 = Convert.ToInt32(dzialanie.Substring(0, dzialanie.IndexOf('+')));
                int liczba2 = Convert.ToInt32(dzialanie.Substring(dzialanie.IndexOf('+') + 1));

                int wynik = liczba1 + liczba2;
                Console.WriteLine(wynik);
            }
            else if (dzialanie.Contains('-'))
            {
                int liczba1 = Convert.ToInt32(dzialanie.Substring(0, dzialanie.IndexOf('-')));
                int liczba2 = Convert.ToInt32(dzialanie.Substring(dzialanie.IndexOf('-') + 1));

                int wynik = liczba1 - liczba2;
                Console.WriteLine(wynik);
            }
            else if (dzialanie.Contains('*'))
            {
                int liczba1 = Convert.ToInt32(dzialanie.Substring(0, dzialanie.IndexOf('*')));
                int liczba2 = Convert.ToInt32(dzialanie.Substring(dzialanie.IndexOf('*') + 1));

                int wynik = liczba1 * liczba2;
                Console.WriteLine(wynik);
            }
            else if (dzialanie.Contains('/'))
            {
                int liczba1 = Convert.ToInt32(dzialanie.Substring(0, dzialanie.IndexOf('/')));
                int liczba2 = Convert.ToInt32(dzialanie.Substring(dzialanie.IndexOf('/') + 1));

                int wynik = liczba1 / liczba2;
                Console.WriteLine(wynik);
            }
            
            else
            {
                Console.WriteLine("Cos nie tak!!!");
            }



            Console.ReadLine();
        }
    }
}
