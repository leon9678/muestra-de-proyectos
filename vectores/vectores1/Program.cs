using System;

namespace vectores1
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, pos;
            int [] numeros = new int[5];
            for (int i = 0; i < 5; i++)
            {
              Console.WriteLine("ingrese un numero:");
              numeros [i] = int.Parse(Console.ReadLine());
              
            }
            max = numeros[0];
            pos = 1;
            for (int i = 0; i < 5; i++)
            {
                if(numeros[i] > max){
                    max = numeros[i];
                    pos = i + 1;
                }
            }
            Console.WriteLine("el numero mas grande dentro del vector es el: " + max + " y su posicion es: " + pos);
            
        }
    }
}
