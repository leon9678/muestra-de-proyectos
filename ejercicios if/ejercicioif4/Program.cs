using System;

namespace ejercicioif4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4,minimo;

            Console.WriteLine("ingrese un numero");

            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese otro numero");

            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese otro numero");

            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el ultimo numero");

            n4 = int.Parse(Console.ReadLine());

            minimo = n1;

            if(n2 < minimo){

                minimo = n2;
            }
            if(n3 < minimo){

                minimo = n3;
            }
            if(n4 < minimo){

                minimo = n4;
            }
            Console.WriteLine("el numero mas bajo es: " + minimo);
        }
    }
}
