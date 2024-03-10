using System;

namespace condicionales1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;

            

            Console.WriteLine("ingrese un numero:");

            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese otro numero");

            n2 = int.Parse(Console.ReadLine());

            if(n1 > n2){

                resultado = n1 - n2;

                Console.WriteLine("se realizo la resta y el resultado es: " + resultado);

            }if(n1 == n2){

                resultado = n1 + n2;

                Console.WriteLine("se realizo la suma y el resultado es: " + resultado);

            }if(n1 < n2){

                resultado = n1 * n2;

                Console.WriteLine("se realizo la multiplicacion y el resultado es: " + resultado);

            
            }
            
        }
    }
}
