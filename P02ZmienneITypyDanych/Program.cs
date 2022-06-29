using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ZmienneITypyDanych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int liczbaCałkowita;
            //liczbaCałkowita = 100;

            //Komentarz do końca linii
            /*Komentarz
             * wielolinikowy
             */

            int liczbaCalkowita = 100; 
            //komentarz
            //01101101 = 109
            //12.3456
            float malaZmiennoprzecinkowa;
            double sredniaZmiennoprzecinkowa;
            decimal duzaZmiennoprzecinkowa;

            //123_456_789 - 123.456.789 123 milionow
            liczbaCalkowita = 123_456_789;//format dzisietny
            liczbaCalkowita = 0xFF; //==255 system, szesnastkowy
            liczbaCalkowita = 0b_01101101; //==109 system binarny
            malaZmiennoprzecinkowa = 1.2F;
            sredniaZmiennoprzecinkowa = 1.2d;
            duzaZmiennoprzecinkowa = 1.2m;

            //zakres widocznosci zmiennych
            //w obrebie klamerek{} została zadeklarowana

            //Przerwa 10:40 

            string napis = "Ala ma Kota";
            string napis2 = "K";
            char znak = 'K';
            //napis2 != znak
            //'\n' '\t' '\\' znaki specjalne enter, tabulator, \

            bool wartosciLogiczne = true; //false //1 and 0

        }
    }
}
