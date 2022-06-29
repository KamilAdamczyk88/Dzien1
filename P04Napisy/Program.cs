using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Napisy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string napis = "Ale ma Kota i ma psa";
            Console.WriteLine(napis.Length);//dlugosc napisu, wywoluemy bez nawiasow
            Console.WriteLine(napis + "i świnkę morska też");//łączenie napisów +
            Console.WriteLine(napis.ToUpper() + " " + napis.ToLower()); //zmiana wielkosci liter
            Console.WriteLine(napis.Substring(5));//od 5 indeksu do końca
            Console.WriteLine(napis.Substring(5,3));//od 5 indeksu 3 znaki
            Console.WriteLine(napis.Contains("ala"));//case sensitive
            Console.WriteLine(napis.IndexOf("ma"));//gdzie znalazl
            Console.WriteLine(napis.IndexOf("tyranazaur"));//jesli nie znajdzie to -1
            Console.WriteLine(napis.Replace("ma", "będzie miała"));
            string brzydkinapis = "    okoń    dla     Wrocławia    ";//usuwanie spacji z poacaku i konca
            Console.WriteLine(brzydkinapis.Trim());


            //Zadanie
            //Na którym miejscu jest drugie "ma"
            Console.WriteLine(napis.LastIndexOf("ma"));
            int pierwszeWystapienie = napis.LastIndexOf("ma");
            Console.WriteLine(napis.IndexOf("ma", pierwszeWystapienie+1));//nie dziala :D

            Console.ReadLine();
        }
    }
}
