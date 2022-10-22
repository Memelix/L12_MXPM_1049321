using System;

namespace L12_MXPEREZM_1049321
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laboratorio 12: promedio de notas");
            int[] notas = new int[15];
            int promedio = 0;
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Nota #  " + (i + 1));
                Console.WriteLine("Ingrese la calificación: ");
                notas[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------------------------");
            }
            for (int i = 0; i < 15; i++)
            {
                promedio = notas[i] + notas[i] /15;
            }
            Console.WriteLine("El promedio es " + promedio);

            Console.ReadKey();
        }
    }
}