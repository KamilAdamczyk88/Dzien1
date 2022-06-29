using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07InstrukcjaWarunkowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            //najprostsza forma
            if (3>4)
            {
                Console.WriteLine("Coś posżło nie tak :(");

            }

            if (3>a)
            {
                Console.WriteLine("Warunek wejściowy spełniony");
                a++;
            }
            else
            {
                Console.WriteLine("Else - warunek wyjsciowy niespełniony");
                a--;
            }

            Console.WriteLine("Dalsza część programu:");


            if (a > 10)
            {
                Console.WriteLine("Pierwszy warunek");
            }

            else if (a < 5)
            {
                Console.WriteLine("Drugi warunek");
            }

            else if (a > 6)
            {
                Console.WriteLine("Trzeci warunek");
            }

            else
            {
                Console.WriteLine("Cała reszta");
            }

            a = (a < 10) ? 5 : 7; //operator zwracajacy wartosc 5 lub 7 w zaleznosci czy a <10 czy nie

            if (a < 10)
            {
                a = 5;
            }
            else
            {
                a = 7;
            }

            switch (a)
            {
                case 10: Console.WriteLine("Poniedziałek"); break;
                case 20: Console.WriteLine("Wtorek"); break;
                case 50: Console.WriteLine("Nie wiem"); break;
            }


            Console.ReadLine();

        }
    }
}
