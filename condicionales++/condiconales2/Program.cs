using System;

namespace condiconales2
{
    class Program
    {
        static void Main(string[] args)
        {
             
            float importetotal, litrosvendidos, importefinal;

            Console.WriteLine("ingrese el importe de la venta:");

            importetotal = float.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la cantidad de litros vendidos:");

            litrosvendidos = float.Parse(Console.ReadLine());

            importefinal = importetotal;

          if(litrosvendidos > 100){

            importefinal = importetotal * 0.90f;

          }
          if(litrosvendidos > 300){

            importefinal = importetotal * 0.85f;
          }
          if(litrosvendidos > 500){

            importefinal = importetotal * 0.75f;

          }

          Console.WriteLine("el importe final es: " + importefinal);
        }   
           
        
    }
}
