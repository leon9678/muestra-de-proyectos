using System;

namespace vectores2
{
    class Program
    {
        static void Main(string[] args)
        {
            int promedio, acumulador = 0;
            int [] numeros = new int [10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ingrese un numero:");
                numeros [i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < 10; i++)
            {
               acumulador += numeros[i];
            }
            promedio = acumulador/10;
            for (int i = 0; i < 10; i++)
            {
                if(numeros [i] > promedio){
                    Console.WriteLine("el numero: " + numeros[i] + " es mayor al promedio");
                }
            }
            Console.WriteLine("el promedio es: " + promedio);
            
            
        }
    }
}
