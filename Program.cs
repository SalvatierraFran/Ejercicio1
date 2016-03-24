using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int max = 0;
            int min = 0;
            int flag = 0;
            int acum = 0;
            float resultado = 0;
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese numero: ");
                num = int.Parse(Console.ReadLine());

                if (num > max)
                {
                    max = num;
                }

                if (flag == 0 && min == 0)
                {
                    min = num;
                    flag = 1;
                }

                if (num < min)
                {
                    min = num;
                }

                acum = acum + num;

                resultado = (float)acum / 5;
            }

            Console.Write("El maximo es " + max);
            Console.Write("\nEl minimo es " + min);
            Console.Write("\nEl promedio es {0:f2}", resultado);
            Console.ReadKey();
        }
    }
}
