using System;
using System.Security.Cryptography.X509Certificates;

namespace ciclofor3
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, promedio, acumulador = 0, contador = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("ingrese una edad:");
                edad = int.Parse(Console.ReadLine());
                if(edad > 18){
                    acumulador += edad;
                    contador++;
                }
            }
            promedio = acumulador / contador;

            Console.WriteLine("el promedio de edad de las personas mayores a 18 años es: " + promedio + " años");
        }
    }
}
