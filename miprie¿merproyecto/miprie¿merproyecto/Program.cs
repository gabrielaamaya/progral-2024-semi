using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miprie_merproyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Num 1 : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Num 2: ");
            int num2 = int.Parse(Console.ReadLine());

            int respuesta = num1 + num2;
            Console.WriteLine(" La suma de {0} + {1} = {2}", num1, num2, respuesta);

            //pausa
            Console.ReadLine();
        }
    }
}
