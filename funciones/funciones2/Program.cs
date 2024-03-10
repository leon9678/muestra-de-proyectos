using System;

namespace funciones2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, resultado, con = 0;
            int[] pares = new int[20];
            for (int i = 0; i < 20; i++)
            {
            Console.WriteLine("ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            resultado = par(n);
            if(resultado == 1){
            pares[i] = n;
            con ++;}
            }
            for (int i = 0; i < 20; i++)
            {
                if(pares[i] > 0)
               Console.WriteLine("el numero: "+ pares[i] +" es par");
            }
            Console.WriteLine("hay: " + con + " numeros pares: ");

        }
        static int par (int n1){
            if(n1 % 2 == 0)
                return 1;
            else
            return 0;

        }
    } 
}
