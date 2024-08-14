using System;
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
            //Uso de matrices.
            int[] numeros = nuevo  int[]  { 2 , 8 , 9 , 10 , 1 , 3 };
            para(int  i = 0 ; i < numeros.Longitud; i++ )  {
                Consola.WriteLine(" Índice: {0}= {1} ", i, numeros[i]);
                int[,] matriz = nuevo  int[,]  {
                    { 5 , 4 , 5 , 2 , 1 } ,
                { 1 , 2 , 8 , 9 , 3 }
                };
                para(int  i = 0 ; i < 2; i++ )  {
                    para(int  j = 0 ; j < 5; j++ )  {
                        Consola.Escribir(" {0} ", matriz[i, j]);
                    }
                    Consola.WriteLine(" \ n ");
                }
                //Pausa
                Consola.ReadKey();

            }
    }
}

