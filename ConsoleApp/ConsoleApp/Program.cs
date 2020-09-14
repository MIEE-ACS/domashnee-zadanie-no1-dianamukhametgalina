using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static int Main(string[] args)
        {
            string e, i, y;
            double E, I, Y, d;
            Console.Write("Введите число А: ");
            e = Console.ReadLine();
            if (!double.TryParse(e, out E))
            {
                Console.WriteLine("Вводить надо число. Конец программы.");
                return 0;
            }
            Console.WriteLine($"Вы ввели число {E}");

            Console.Write("Введите число B: ");
            i = Console.ReadLine();
            if (!double.TryParse(i, out I))
            {
                Console.WriteLine("Вводить надо число. Конец программы.");
                return 0;
            }
            Console.WriteLine($"Вы ввели число {I}");

            Console.Write("Введите число C: ");
            y = Console.ReadLine();
            if (!double.TryParse(y, out Y))
            {
                Console.WriteLine("Вводить надо число. Конец программы.");
                return 0;
            }
            Console.WriteLine($"Вы ввели число {Y}");
            Console.WriteLine("Изменим значение переменных,переместив содержимое А в С,С в В и В в А");
            d = E;
            E = I;
            I = d;
            d = Y;
            Y = I;
            I = d;
            Console.WriteLine("{0:0.000}", E);
            Console.WriteLine("{0:0.000}", I);
            Console.WriteLine("{0:0.000}", Y);
            return 0;
        }
    }
}
