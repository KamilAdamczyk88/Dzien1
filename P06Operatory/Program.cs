using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Operatory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //* / + -
            // % modulo czyli reszta z dzielenia
            int a = 10;
            int b = 3;
            Console.WriteLine(a / b);
            Console.WriteLine(10.0 / 3);
            Console.WriteLine(10.0 % 3);
            a++;
            ++a;
            a--;
            --a;

            a = 10;
            Console.WriteLine(a++);
            a = 10;
            Console.WriteLine(++a);

            //łączenie warunków (operatory w kolejnosci wykonywania)
            //negacja       !
            //AND           &
            //OR            |
            //XOR           ^ - musza byc rozne, albo albo. true i true da falsz i odwrotnie.
            //warunkowy AND && - leniwe wyliczanie
            //warunkowy OR || - leniwe wyliczanie jesli lewa jest prawda to drugi warunek jest pomijany.
            //uwaga na efekty ubczne leniwych operatorow
            int? x = null;
            Console.WriteLine(x == null || x > 2);
            x = 12;//a co jesli x = 7?
            Console.WriteLine(x>10 && x++ <20);
            Console.WriteLine(x);

            //operator konkatenacji
            Console.WriteLine("5" + "4");

            Console.ReadLine();
        }

    }
}
