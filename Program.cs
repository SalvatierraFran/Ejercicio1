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
            }

            Console.Write("El maximo es " + max);
            Console.Write("\nEl minimo es " + min);
            Console.ReadKey();
        }
    }
}
