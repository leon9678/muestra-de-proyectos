using System;

namespace funciones3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, acu = 0; 
            float promedio, con = 0;
            Console.WriteLine("ingrese los numeros, precione cero para dejar de cargar numeros: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                if(primo (n)){
                con ++;
                acu += n;
                }
                n = int.Parse(Console.ReadLine());
            }
            promedio = acu / con;
            Console.WriteLine("hay: " + con + " numeros primos y el promedio de ellos es:  " + promedio.ToString("0.00"));
            

        }
        static bool primo (float n1){
            int con = 0;
            for (int i = 1; i <= n1; i++)
            {
                if(n1 % i == 0){
                    con ++;
                }
            }
            bool bandera = true;
            if(con == 2)
            return bandera;
            else
            return bandera = false;
        }
    }
}
