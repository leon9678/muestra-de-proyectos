using System;
using System.Text.RegularExpressions;

namespace funciones4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, nvoid = 'l';
            Console.WriteLine("ingrese un numero:");
            n = int.Parse(Console.ReadLine());
            calculador(n, ref nvoid);
                switch (nvoid)
            {
                case 1:
                Console.WriteLine("positivo");
                break;
                case 0:
                Console.WriteLine("cero");
                break;
                case -1:
                Console.WriteLine("negativo");
                break;
                default:
                Console.WriteLine("lo que ingresaste no se corresponde con el programa: ");
                break;
            }
        
        }
        static void calculador ( int n,ref int n1){

             if(n == 0)
                n1 = 0; 
            else if(n > 0)
                n1 = 1;
            else
            n1 = -1;

        }
    }
}
