using System;

namespace ConsoleApp1
{
    class HomeTask1
    {
        static void Main()
        {
            //FahrenheitToCelcius();
            ThreeFiveTwenty();
            //DayOfWeek();
            //NumberOfHolidays();
        }

        static void FahrenheitToCelcius()
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

        static void ThreeFiveTwenty()
        {
            /*
             * При старте приложение запрашивает у пользователя два целых числа a и b. 
             * Затем приложение считает и выводит сумму всех целых чисел в диапазоне от a и b (включительно), 
             * которые делятся без остатка или на 3, или на 5, но не делятся на 20. 
             * Разработать консольное приложение, реализующее указанный функционал.
             */
            int sum = 0;
            Console.Write("Input whole number a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input whole number b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            while (b < a)
            {
                Console.WriteLine("b must be equal or greater than a. Input b again:");
                b = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = a; i < b + 1; i++)
            {
                if ((i % 20 != 0) && ((i % 3 == 0) || (i % 5 == 0)))
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine("Sum = " + sum);
            Console.ReadKey();
        }

        static void DayOfWeek()
        {
            /*
             * Пользователь вводить номер дня недели от 1 до 7. 
             * Приложение выводит название дня недели на русском языке. 
             * Вместо «суббота» и «воскресенье» приложение выводит «выходной!».
             */
            Console.Write("Input number of weekday: ");
            int dayOfWeekNumber = Convert.ToInt32(Console.ReadLine());
            while ((dayOfWeekNumber > 7) || (dayOfWeekNumber < 1))
            {
                Console.WriteLine("Entered text is not a number of weekday. Please input a number between 1 and 7: ");
                dayOfWeekNumber = Convert.ToInt32(Console.ReadLine());
            }
            switch (dayOfWeekNumber)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                default:
                    Console.WriteLine("Выходной");
                    break;
            }
            Console.ReadKey();
        }

        static void NumberOfHolidays()
        {
            /*
            * 1 января 2016 года – это пятница. В 2016 году 366 дней. 
            * Приложение считает и печатает, сколько в 2016 году выходных дней 
            * (имеются ввиду только субботы и воскресенья).
            */
            int numberOfHolidaysInYear = 0;
            // 1st of January is Friday means that Saturday and Sunday are 2nd and 3rd days of each week
            for (int i = 1; i < 367 + 1; i++)
            {
                if ((i % 7 == 2) || (i % 7 == 3))
                {
                    numberOfHolidaysInYear++;
                }
            }
            Console.WriteLine("Number of holidays in the year is: " + numberOfHolidaysInYear);
            Console.ReadKey();
        }
    }

}
