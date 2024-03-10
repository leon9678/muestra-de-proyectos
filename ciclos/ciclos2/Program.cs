using System;
using System.Security.Cryptography.X509Certificates;

namespace ciclofor2
{
    class Program
    {
        static void Main(string[] args)
        {
            //un ciclo for hecho con un ciclo while

            //esto se puede usar tanto para buscar un maximo como un minimo
            int n1 = 0,con = 0, minimo;

            Console.WriteLine("ingrese un numero: ");

            n1 = int.Parse(Console.ReadLine());

            minimo = n1;

            con++;

            while (con < 10)
            {
                Console.WriteLine("ingrese otro numero: ");
                n1 = int.Parse(Console.ReadLine());
                if(n1 < minimo){
                    minimo = n1;
                }
                con++;
            }
            Console.WriteLine("el numero mas chico que ingresaste es el: " + minimo);

             
            
        }
    }
}
