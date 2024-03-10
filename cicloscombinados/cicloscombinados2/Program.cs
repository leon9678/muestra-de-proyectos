using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Xml;

namespace cicloscombinados2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,conn, coni, porcentajemax = 0, porcentajeimp = 0, nugru = 0, nm,conor = 0;
            
            
            for (int i = 0; i < 5; i++)
            {
                bool bandera = true;
                conn = 0;
                coni = 0;
                Console.WriteLine("ingrese los numeros");
                n = int.Parse(Console.ReadLine());
                nm = n;
                while (n != 0)
                {
                    conn = 0;
                    if(n % 2 == 0){
                    coni++;}
                    conn++;
                    
                    if(n <= nm)
                    nm = n;
                    else
                    bandera = false;
                    
                    n = int.Parse(Console.ReadLine());
                    
                }
                porcentajeimp = (coni / 100) * conn;
                    if(porcentajeimp >= porcentajemax){
                        porcentajemax = porcentajeimp;
                        nugru = i + 1;}
                        if(bandera)
                        conor ++;      
                
            }
            Console.WriteLine("el grupo con mayor porcentaje de impares es: " + nugru);
            Console.WriteLine("la cantidad de grupos con numeros ordenados es: " + conor);
        }
    }
}
