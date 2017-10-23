using System;

namespace ConsoleApp1
{
    /*
     * Задание 1. 
     *  Создайте обобщенный класс для представления сущности (Entity). 
     *  Атрибуты сущности – ID, Name, Description. 
     *  Тип ID определяется generic-параметром, тип Name и Description – это string. 
     *  Ограничение на generic-параметр – это может быть только структура.
     */
    class HomeTask4
    {

        static void Main()
        {
            Point3D p1 = new Point3D(2,5,8);
            var Test = new Entity<Point3D>();
            Test.SetT(p1);
            Console.WriteLine(Test.GetT());
            Console.ReadKey();
            
        }

        public class Entity<T>
                        where T : struct
        {
            private T ID;

            public T GetT()
            {
                return ID;
            }

            public void SetT(T value)
            {
                ID = value;
            }

            public string Name { get; set; }
            public string Description { get; set; }
        }

        public struct Point3D
        {
            public double X { get; }
            public double Y { get; }
            public double Z { get; }

            public Point3D(double x, double y, double z = 0.0)
            {
                X = x; Y = y; Z = z;
            }

            public Point3D(Point3D point)
            {
                this = point;
            }
        }
    }
}
