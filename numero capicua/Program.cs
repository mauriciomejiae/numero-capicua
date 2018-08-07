using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_capicua
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nombre del Autor: Mauricio Mejia Estevez
            //Fecha: 08 Noviembre 2016
            //Doy fe que este ejercicio es de mi autoría, en caso de encontrar plagio la nota de todo mi
            //trabajo debe ser de CERO además de las respectivas sanciones a que haya lugar
            //3. Se lee un número de máximo tres dígitos (verifique que efectivamente sea de máximo tres dígitos)
            //y se debe determinar si es un número capicúa, es decir, que leído de izquierda a derecha es igual que 
            //leído de derecha a izquierda. Por ejemplo: 727, 343, etc.

            Console.WriteLine(" ");
            Console.WriteLine("Ingrese el número de tres digitos: ");
            Console.WriteLine(" ");
            int Nro = int.Parse(Console.ReadLine());
            int C = Nro / 100;
            int U = Nro % 10;
            if (C == U)
            {
                Console.WriteLine(" El número Dijitado Es un Numero capicúa ");
            }
            else
            {
                Console.WriteLine(" El número Dijitado No es un Numero capicúa ");
            }
            Console.ReadKey();
        }
    }
}