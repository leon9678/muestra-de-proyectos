using System;

namespace vectores5
{
    class Program
    {
        static void Main(string[] args)
        {
         int numerodearticulo, cantidadvendida, articulomax = 0;
         int[] cantidadvendidav = new int[15];
         for (int i = 0; i < 15; i++)
         {
            cantidadvendidav[i] = 0;
         }
         
         Console.WriteLine("ingrese el numero de articulo: ");
         numerodearticulo = int.Parse(Console.ReadLine());
         Console.WriteLine("ingrese la cantidad vendida");
         cantidadvendida = int.Parse(Console.ReadLine());
         while (numerodearticulo != 0)
         {
            cantidadvendidav [numerodearticulo - 1] += cantidadvendida;
         Console.WriteLine("ingrese el numero de articulo:");
         numerodearticulo = int.Parse(Console.ReadLine());
         Console.WriteLine("ingrese la cantidad vendida");
         cantidadvendida = int.Parse(Console.ReadLine());
         
        }
        for (int i = 0; i < 15; i++)
        {
            if(cantidadvendidav[i] > articulomax){
                articulomax = cantidadvendidav[i];
                numerodearticulo = i + 1;
            }
        }
        for (int i = 0; i < 15; i++)
        {
            if(cantidadvendidav[i] == 0)
            Console.WriteLine("el producto numero: " + (i+1) + " no registro ventas:");
        }
        for (int i = 0; i < 15; i++)
        {
            if(i == 10)
            Console.WriteLine("la cantidad vendida del articulo numero 10 es: " + cantidadvendidav[9]);
        }
        Console.WriteLine("el numero de producto que mas ventas registro es: " + numerodearticulo + " con " + articulomax + " cantidadesvendidas");
        }
    }
}
