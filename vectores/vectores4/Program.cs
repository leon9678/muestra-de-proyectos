using System;
using System.Security.Cryptography.X509Certificates;

namespace vectores4
{
    class Program
    {
        static void Main(string[] args)
        {
            char letraactual, letranueva, letra;
            char[] cadena = new char[30];
            int i = 0;
            Console.WriteLine("ingrese una frase letra por letra corta con punto");
            letra = char.Parse(Console.ReadLine());
            while (letra != '.' && i < 30)
            {
                cadena [i] = letra;
                letra = char.Parse(Console.ReadLine());
                i ++;
                
            }
            cadena [i] = '\0';
            Console.WriteLine("la frase completa es: ");
            i = 0;
            while (cadena[i] != '\0' && i <30)
            {
                Console.Write(cadena[i]);
                i ++;
            }
            Console.WriteLine(" seleccione la letra que desea cambiar: ");
            letraactual = char.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la nueva letra:");
            letranueva = char.Parse(Console.ReadLine());
            i = 0;
            while (cadena[i] != '\0')
            {
                if(letraactual == cadena[i]){
                    cadena[i] = letranueva;
                }
                i ++;
            }
            i = 0;
            while (cadena[i] != '\0')
            {
                Console.Write(cadena[i]);
                i ++;
            }
        
            

        
            
        }
    }
}
