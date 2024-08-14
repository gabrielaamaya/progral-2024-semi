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
            //Uso de matrices. Calcula el suelo de una persona.
            double[,] matriz = new  double[,]  {
                { 0,01 ,    472,00 ,   0 ,  0 } ,
                { 472.01 ,  895,24 ,  10 , 17,67 } ,
                { 895.25 ,  2037,10 ,  20 , 60,00 } ,
                { 2038,11 , 9999999 , 30 , 288,57} ,
                
            };
            Console.Write(" Sueldo: ");
            double sueldo = double.Parse(Console.ReadLine());
            double    afp = sueldo * 7.25 / 100;
          Double  isss = sueldo * 3 / 100;
            isss = sueldo * 3 / 100;
               double esr = 0;
           sueldo -= afp;

            double isr = 0;
            for(int  i = 0 ; i < 4; i++ )  {
                if (sueldo <= matriz[i, 0] && sueldo >= matriz[i, 1])
                {
                    isr = (sueldo - (matriz[i, 0] - 0.01)) * matriz[i, 2] / 100 + matriz[i, 3];
                }
            }
            sueldo -= isss;
            sueldo -= isr;
            Console.WriteLine(" Sueldo Neto: {0}, AFP: {1}, ISSS: {2}, ISR: {3} ", Math.Round(sueldo, 2), afp, isss, Math.Round(isr, 2));
            Console.ReadLine();

        }
    }
}

