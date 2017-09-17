using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FirstProgram
    {
        static void Main()
        {
            Console.Write("Input miles: ");
            string s = Console.ReadLine();
            double miles = double.Parse(s);
            Console.Write("In kilometers: ");
            Console.WriteLine(miles * 1.609);
            Console.ReadKey();
        }
    }

}
