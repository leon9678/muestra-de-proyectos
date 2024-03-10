using System;

namespace ciclofor4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con = 0;

            Console.WriteLine("ingrese un numero:");

            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
               if(n % i == 0){

                con ++;
               } 
            }
            if(con == 2)

                Console.WriteLine("el numero es primo");
            
            else

                Console.WriteLine("el numero no es primo");
            
        }
    }
}
