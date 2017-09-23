using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FahrenheitToCelcius
    {
        static void Main()
        {
            /*
             * добиться запуска этой программы в выбранной IDE или скомпилировать и запустить её при помощи компилятора командной строки.
             * изменить программу, чтобы она переводила градусы из шкалы Фаренгейта в шкалу Цельсия.
             * Для перевода температуры из шкалы Фаренгейта в шкалу Цельсия нужно от исходного числа отнять 32 и умножить результат на 5/9. 
             */
            Console.Write("Input Fahrenheit: ");
            string s = Console.ReadLine();
            double degrees = double.Parse(s);
            Console.Write("In Celcius: ");
            Console.WriteLine((degrees - 32) * 5 / 9);
            Console.ReadKey();
        }
    }

}
