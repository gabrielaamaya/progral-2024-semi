using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mi_primer_proyecto
{
    internal class Program
    {
        static void Main(string[] args){
            //uso de funciones..
            Console.WriteLine("La sum de 10+5={0}", suma());
            Console.ReadLine();
            {
                static int suma();
                int respuesta = 10 + 5;
                return respuesta;
            }
        }
    }
}
