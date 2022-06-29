using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03Konsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoje imię:");
            string napis = Console.ReadLine();

            Console.WriteLine("Witaj " + napis);

            Console.WriteLine("Twoje imie ma dlugosc: "+napis.Length.ToString());

            Console.WriteLine("Po śląsku nazywasz się: " + napis.Replace('a', 'o'));
            napis = napis.Replace('o', 'b');
            Console.WriteLine("Twoj tajny nick to: " + napis.ToUpper());
            Console.WriteLine("Ile masz lat?");
            int wiek = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Urodziłeś/aś się w roku: " + (2022 - wiek));

            //Stringi z dolarem i klamrami 
            Console.WriteLine($"Rok urodzenia: {2022-wiek} a długość imienia: {napis.Length}");

            Console.ReadLine();
        }

        
    }
}
