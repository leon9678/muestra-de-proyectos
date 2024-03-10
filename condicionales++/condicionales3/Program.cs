using System;

namespace condicionales3
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

            switch(procesador){

                case 1 :
                switch(ram){

                    case 1:
                    costo = costo + 800;
                    break;

                    case 2 :
                    costo = costo + 900;
                    break;

                    case 3 :
                    costo = costo + 1000;
                    break;

                    default:
                    Console.WriteLine("el numero ingresado no es valido");
                    break;

                    
                }
                break;
                case 2:
                switch(ram){

                    case 1 :
                    costo = costo + 900;
                    break;

                    case 2 :
                    costo = costo + 1000;
                    break;

                    case 3 :
                    costo = costo + 1400;
                    break;

                    default:
                    Console.WriteLine("el numero ingresado no es valido");
                    break;
                }
                break;
                case 3:
                switch(ram){

                    case 1 :
                    costo = costo + 1200;
                    break;

                    case 2 :
                    costo = costo + 1400;
                    break;

                    case 3 :
                    costo = costo + 2000;
                    break;

                    default:
                    Console.WriteLine("el numero ingresado no es valido");
                    break;
                }
                break;

                default:
                Console.WriteLine("el numero ingresado no es valido");
                break;
            }

            if(discoduro == 1){

                costo += 300;
            }

            costofinal = costo;

            Console.WriteLine("el costo de la pc en dolares es: " + costofinal + "usd");
            

        }    

            

            
        
    }
}
