using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09Petle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i
            ////petla przydatna kiedy wiem ile dokladnie razy ma sie wykonac
            //for (i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Kolejny obrót pętli {i}");
            //}
            //Console.WriteLine(i);
            //int i;
            //for (int a = 1; a <= 9; a++)
            //{

            //    for (i = 1; i <= 9; i++)
            //    {
            //        Console.Write($"\t{ i * a} ");
            //    }
            //    Console.WriteLine($"\n ");

            //}
            //int k = 1;
            //while (k<1E6)
            //{
            //    Console.WriteLine(k);
            //    k *= 2;

            //}
            //Console.WriteLine(k);


            //petla do while - wykona sie na pewno conajmniej 1 raz
            //warunek jest sprawdzany po wykonaniu kodu
            //int i = 1;
            //do
            //{
            //    Console.WriteLine(i);
            //    i *= 2;
            //} while (i < 1E6);
            ////break - wyjscie z petli
            ////continue - wyjscie z obrotu petli


            //for (int i = 0; i < 10; i++)
            //{
            //    if (i % 3 == 0) continue;
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            while (true)
            {
                if (Console.ReadKey().KeyChar == 'a') break;
                
            }




            Console.ReadLine();
        }
    }
}
