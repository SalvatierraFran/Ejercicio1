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

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese numero: ");
                num = int.Parse(Console.ReadLine());

                if (num > max)
                {
                    max = num;
                }
            }

            Console.Write("El maximo es " + max);
            Console.ReadKey();
        }
    }
}
