using System;

namespace ejercicioif3
{
    class Program
    {
        static void Main(string[] args)
        {
            float importe, importefinal;

            Console.WriteLine("ingrese el importe");

            importe = float.Parse(Console.ReadLine());

            importefinal = importe;

            if(importe >= 1000){

                if(importe >= 5000){

                    importefinal = importe * 0.82f;
                }
                else{
                    importefinal = importe * 0.90f;
                }
                
            }
            Console.WriteLine("el importe es: " + importefinal);
            
        }
    }
}
