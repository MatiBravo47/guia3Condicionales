using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
            
            /*
            int edad;
            string resultado;
            Console.WriteLine("Ingresa tu edad");
            edad = int.Parse(Console.ReadLine());
            resultado = edad > 18 ? "Puede conducir" : "No puede conducir";
            Console.WriteLine(resultado);
            Console.ReadLine();
            */
            
            /*
             2)Control de acceso:
             a)Pregunta: Ingresa tu nombre y edad para determinar si puedes acceder 
             a un evento
             b)Variables: int(edad), string(nombre)
             c)Condicionales: if-else
            */
            /*
            int edad;
            string nombre;

            Console.WriteLine("Ingresa tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu edad");
            edad = int.Parse(Console.ReadLine());

            if (edad >= 18 )
            {
                Console.WriteLine(nombre + " puede ingresar al evento");
            }
            else
            {
                Console.WriteLine(nombre + " no puede ingresar al evento");
            }
            Console.ReadLine();
            */
            
        }
    }
}
