using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            1)Edad para conducir:
            a)Pregunta: Ingresa tu edad para determinar si puedes obtener 
            tu licencia de conducir.
            b)Variables: int (edad)
            c)Condicionales: if-else
            */
            int edad;
            string resultado;
            Console.WriteLine("Ingresa tu edad");
            edad = int.Parse(Console.ReadLine());
            resultado = edad > 18 ? "Puede conducir" : "No puede conducir";
            Console.WriteLine(resultado);
            Console.ReadLine();

            /*
             * 
             * 
            */ 
        }
    }
}
