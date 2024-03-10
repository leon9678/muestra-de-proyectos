using System;
using System.Timers;

namespace ciclos5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, maximo = 0, minimo = 0;
            bool banderapar = false, banderaimpar = false;

            for (int i = 0; i < 20; i++)
            {
            Console.WriteLine("ingrese un numero");
            n = int.Parse(Console.ReadLine());

                if(n % 2 == 0){

                    if(!banderapar){
                        if(n > maximo){
                            maximo = n;
                        }
                    }
                    else{

                        maximo = n;

                        banderapar = true;
                    }
                    }
                    else if(!banderaimpar){

                        if(n > maximo){

                            minimo = n;
                        }
                        else{

                            minimo = n;

                            banderaimpar = true;
                        }
                    }
           }
           if(!banderapar)
           Console.WriteLine("el mayor de los pares es: " + maximo);
            else
            Console.WriteLine("no hay numeros pares");
            if(!banderaimpar)
            Console.WriteLine("El menor de los impares es: " + minimo);
            else
            Console.WriteLine("no hay numeros impares");
            

           
            
            
        }
    }
}
