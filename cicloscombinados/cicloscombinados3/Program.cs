using System;

namespace cicloscombinados3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1, con, conl = 0, cong = 0;

            
            while (n >= 0)
            {
                con = 0;
                Console.WriteLine("ingrese numeros");
            n = int.Parse(Console.ReadLine());
            if(n > 0)
            con ++;
                
            
            while (n > 0)
            {
               Console.WriteLine("ingrese un numero");
               n = int.Parse(Console.ReadLine());
               if(n > 0)
               con ++; 
            }
            if(n > -1){
              conl ++;  
            Console.WriteLine("la cantidad de numeros de la lista numero: " + conl + " es de " + con + " numeros");
            }
            cong += con;

            }
            Console.WriteLine("hay: " + conl + " listas y la suma de todos sus numeros es: " + cong );
        }
    }
}
