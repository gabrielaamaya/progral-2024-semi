﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mi_primer_proyecto
{
    internal class Program
    {
        static void Main(string[] args){
            // estructura de control.
            //2. cambiar el ejercicio. Pedir al usuario la edad si es mayor de edad que le diga bienvenido.
            string continuar = "s";
            Console.WriteLine("MENU ****");
            Console.WriteLine(" \n \n*** MENU ***");
            Console.WriteLine("1.promedio notas");
            Console.WriteLine("2.promedio serie numeros");
            Console.WriteLine("3.clasificacion edad");
            Console.WriteLine("4.salir");
            Console.WriteLine("4.tabla multiplicar");
            Console.WriteLine("5.salir");
            Console.WriteLine("opcion:");
            int opcion = int.Parse(Console.ReadLine());
            Console.Claro(); // Limpiar la consola
            switch (opcion)
            {
                case 1: // Si (opcion == 1)
                    promedio();
                    break;
                case 2: // Si (opcion == 2)
                    promedioSerie();
                    break;
                case 3: // Si (opcion == 3)
                    clasificacionEdad();
                    break;
                case 4: // Si (opcion == 4)
                    tablaMultiplicar();
                    break;
                case 5: // Si (opcion == 5)
                    continuar = "n";
                    break;
                default: // De lo contrario
                    Console.WriteLine("Opción incorrecta\n\n");
                    break;
            }
            void tablaMultiplicar()
            {
                Console.Write("Tabla: ");
                int ntabla = int.Parse(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("{0}x{1} = {2}", ntabla, i, ntabla * i);
                }
            }
            void promedio()
            {
                Console.Write("Lab1: ");
                double lab1 = double.Parse(Console.ReadLine());

                Console.Write("Lab2: ");
                double lab2 = double.Parse(Console.ReadLine());

                Console.Write("Parcial 1: ");
                double parcial1 = double.Parse(Console.ReadLine());

                double c1 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
                Console.WriteLine("La nota de C1 es: {0}", c1);

                Console.Write("Lab1: ");
                lab1 = double.Parse(Console.ReadLine()); // 8

                Console.Write("Lab2: ");
                lab2 = double.Parse(Console.ReadLine()); // 9

                Console.Write("Parcial 1: ");
                parcial1 = double.Parse(Console.ReadLine()); // 7

                double c2 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
                Console.WriteLine("La nota de C2 es: {0}", c2);
            }

            void promedioSerie()
            {
                int[] serie = new int[] { 5, 4, 6, 8, 9 }; // Suma total: 32
                int suma = 0;

                foreach (int num in serie)
                {
                    suma += num;
                }

                double promedio = (double)suma / serie.Length;
                Console.WriteLine("La suma es: {0}, el promedio {1}", suma, promedio);
            }

            void clasificacionEdad()
            {
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());

                if (edad < 0)
                {
                    Console.WriteLine("Edad incorrecta.");
                }
                else if (edad <= 2)
                {
                    Console.WriteLine("Eres un bebé.");
                }
                else if (edad < 12)
                {
                    Console.WriteLine("Eres un niño.");
                }
                else if (edad < 18)
                {
                    Console.WriteLine("Eres un adolescente.");
                }
                else if (edad <= 65)
                {
                    Console.WriteLine("Bienvenido al mundo de las responsabilidades.");
                }
                else if (edad <= 80)
                {
                    Console.WriteLine("Eres un adulto mayor.");
                }
                else
                {
                    Console.WriteLine("Larga vida.");
                }
            }
            //Uso de matrices.
            int[] numeros = new  int[]  { 2 , 8 , 9 , 10 , 1 , 3 };
            Console.WriteLine(" El numero de la posicion 3 es {0} ", numeros[3]);
            //Pausa
            Console.ReadKey();

        }
    }
}

