using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            Console.WriteLine("Введите x и y");
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            z = Math.Pow(3, -x) - Math.Cos(x) + Math.Sin(2 * x * y);
            Console.WriteLine($"z = {z}");
            /*Console.WriteLine("z = " + z);
            Console.WriteLine("z = {0}", z);*/
            Console.WriteLine("Введите длины катетов x и y");
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            z = Math.Sqrt(x * x + y * y) + x + y;
            Console.WriteLine($"Периметр = {z}");
            z = y * x * 0.5;
            Console.WriteLine($"Площадь = {z}");
            Console.ReadKey();
        }
    }
}
