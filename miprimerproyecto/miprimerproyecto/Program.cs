using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miprimerproyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("lab1: ");
            double lab1 = double.Parse(Console.ReadLine());

            Console.Write("lab2: ");
            double lab2 = double.Parse(Console.ReadLine());

            Console.Write("parcial1: ");
            double pacial1 = double.Parse(Console.ReadLine());

            double c1 = lab1 * 30 / 100 + lab2 * 20 / 100 + pacial1 * 40 / 100;
            Console.WriteLine("La nota de C1 es: {0}", c1);
           
            Console.Write("lab1: ");
            double lab1 = double.Parse(Console.ReadLine());

            Console.Write("lab2: ");
            double lab2 = double.Parse(Console.ReadLine());

            Console.Write("parcial2: ");
            double parcial2 = double.Parse(Console.ReadLine());

            double c2 = lab1 * 30 / 100 + lab2 * 20 / 100 + pacial1 * 40 / 100;
            Console.WriteLine("La nota de C2 es: {0}", c2);

            Console.Write("lab1: ");
            double lab1 = double.Parse(Console.ReadLine());

            Console.Write("lab2: ");
            double lab2 = double.Parse(Console.ReadLine());

            Console.Write("parcial1: ");
            double pacial3 = double.Parse(Console.ReadLine());

            double c3 = lab1 * 30 / 100 + lab2 * 20 / 100 + pacial1 * 40 / 100;
            Console.WriteLine("La nota de C3 es: {0}", c1);

        }
    }
}
