using System;

namespace condicionales5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;

            Console.WriteLine("ingrese un numero: ");

            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero: ");
            
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingre el tercer numero: ");

            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el ultimo numero: ");

            n4 = int.Parse(Console.ReadLine());

            if(n1 > n2 && n2 > n3 && n3 > n4){

                Console.WriteLine("los numero estan ordenados de manera decreciente: ");
            }
            else{

                Console.WriteLine("los numeros no estan ordenados de forma decreciente: ");

                
            }
        }
    }
}
