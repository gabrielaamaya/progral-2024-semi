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
            Console.WriteLine(" Num1 : ");
            int num1 = int.Parse(Console.ReadLine());
          num1 =  sbyte.Parse(Console.ReadLine());

            Console.WriteLine(" Num 2 :");
            int num2 = int.Parse(Console.ReadLine());
            num2 = sbyte.Parse(Console.ReadLine());

            int respuesta = num1 + num2;
            Console.WriteLine(" la suma de {0} + {1} = {2} ", num1, num2, respuesta);
            int suma = num1 + num2;


            //pausa.
            Console.ReadLine();
        }

    }
}
