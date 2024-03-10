using System;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Threading;

namespace cicloscombinados
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con, conp = 0, pos = 0;
            for (int i = 1; i <= 10; i++)
            {
                pos++;
             Console.WriteLine("ingrese un numero");
             n = int.Parse(Console.ReadLine());
             con = 0;
             for (int y = 1; y <= n; y++)
             {
              if(n % y == 0){
                con++;
              }  
             }
             if(con == 2){
                conp++;
                pos = i;
                Console.WriteLine("la cantidad de numeros primos ingresados es: " + conp + " y la posicion es: " + pos);
             }
             Console.WriteLine("la posicion es: " + pos);
             
            }
            if(conp == 0){
                Console.WriteLine("no se encontraron numeros primos");
             }
            

        }
    }
}
