using System;
using System.Data.Common;

namespace otraformadehacerlo
{
    class Program
    {
        static void Main(string[] args)
        {
         int procesador, ram, discoduro;

            float costo, costofinal;

            costo = 0;
            costofinal = 0;

            Console.WriteLine("seleccione el procesador");

            procesador = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la opcion de ram");

            ram = int.Parse(Console.ReadLine());

            Console.WriteLine("desea ampliar el disco duro?");

            discoduro = int.Parse(Console.ReadLine());

            if(procesador == 1 && ram == 1){

                costo += 800;
            }
            if(procesador == 1 && ram == 2){

                costo += 900;
            }
            if(procesador == 1 && ram == 3){

                costo += 1000;
            }
            if(procesador == 2 && ram == 1){

                costo += 900;
            }
            if(procesador == 2 && ram == 2){

                costo += 1000;
            }
            if(procesador == 2 && ram == 3){

                costo += 1400;
            }
            if(procesador == 3 && ram == 1){

                costo += 1200;
            }
            if(procesador == 3 && ram == 2){

                costo += 1400;
            }
            if(procesador == 3 && ram == 3){

                costo += 2000;
            }

            if(discoduro == 1){

                costo += 300;
            }
            costofinal = costo;

            Console.WriteLine("el precio de la pc es de: " + costofinal + " usd");
        }
    }
}
