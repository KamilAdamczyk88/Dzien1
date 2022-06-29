using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadanieNapisy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Podaj pierwsza liczbe:");
            //int liczba1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Podaj druga liczbe:");
            //int liczba2 = Convert.ToInt32(Console.ReadLine());
            //int wynik = liczba1 + liczba2;
            //Console.WriteLine(wynik);
            //Console.WriteLine(wynik.ToString().Length);

            Console.WriteLine("Drugie zadanie:");
            
            const char SEP = '-'; //stała, separator
            Console.WriteLine($"Podaj dwie liczby rozdzielone znakiem '{SEP}'");
            string napis = Console.ReadLine();
            int liczba1 = Convert.ToInt32(napis.Substring(0,napis.IndexOf(SEP)));
            int liczba2 = Convert.ToInt32(napis.Substring(napis.IndexOf(SEP)+1));
            
            int wynik = liczba1 - liczba2;
            Console.WriteLine(wynik);
            Console.ReadLine();


        }
    }
}
