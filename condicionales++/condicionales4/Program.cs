using System;

namespace condicionales4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, suma, producto;

            Console.WriteLine("ingrese un numero:");

            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero:");

            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el ultimo numero:");

            n3 = int.Parse(Console.ReadLine());

            suma = n1 + n2;

            producto = n2 * n3;

            if(suma > producto){

                Console.WriteLine("la suma es mayor al producto: ");
            }
            else{

                Console.WriteLine("el producto es mayor a la suma: ");
            }
        }
    }
}
