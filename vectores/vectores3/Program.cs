using System;

namespace vectores3
{
    class Program
    {
        static void Main(string[] args)
        {
            //esto es una cadena de caracteres notese que es solo un vector de tipo char(letras) pero
            //ladiferencia entre un vector de tipo char y una cadena es cuando cortan
            //mientras que el vector de tipo char corta cuando el vector llega a su indicie final
            //la cadena de caracteres corta con un caracter especial que es el (\0) esa es la diferenccia entre los dos
            //aunque al final del dia son los dos lo mismo un vector de tipo char la diferencia es solo conceptual.
            int i = 0, x = 0;
            char letra;
            char[] nombre = new char[20];

            Console.WriteLine("ingrese su nombre letra por letra:");
            letra = char.Parse(Console.ReadLine());
           while (letra != '.' && i < 20)
           {
            nombre [i] = letra;
            letra = char.Parse(Console.ReadLine());
            i ++;
           }
           Console.Write("hola ");
           nombre[i] = '\0';
            while (nombre[x] != '\0' && x < 20)
            {
                Console.Write(nombre [x]);
                x ++;
            }
            //esto de aca abajo es el tipo string que permite hacer esto de manera mucho mas dinamica
            //pero es programacion a alto nivel y no se ve mucho que esta pasando por detras por lo tanto no es
            //muy buena idea aprender solo eso
            //por ejemplo lo de arriva es programacion a bajo nivel y es mucho mejor aprender de esa manera
            //por que aunque asi sea muho mas dificil ahi se ve realmente como funciona la logica de programacion
            //{string nombre;
            //Console.WriteLine("ingrese su nombre");
            //nombre = Console.ReadLine();
            //Console.WriteLine("hola: " + nombre);}
            
            
        }
    }
}
