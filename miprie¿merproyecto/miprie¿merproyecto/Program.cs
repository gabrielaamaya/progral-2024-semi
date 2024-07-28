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
            Boolean comprobar = true;
            Console.WriteLine("El valor es: {0}", comprobar);

            //prioridad de los operadores aritmeticos.
            //se pone el sufijo m para la division con decimales.

            decimal respuesta = 5 + 8 - 2 * 5 / 4m + 1; //14.75 valor incorrecto; 11.5 → valor correcto

            Console.WriteLine("La respuesta es: {0} ", respuesta) ;

            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Hola {0} bienvenido ", nombre);

            DateTime fechaActual = new DateTime();
            fechaActual = DateTime.Now;
            Console.WriteLine(" La fecha actual es : {0} ", fechaActual);

            //pausa.
            Console.ReadLine();
        }
    }
}
