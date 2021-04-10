using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número con decimales");
            decimal numero = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"El número ingresado es {numero} \r\n" +
                "y el número redondeado en dos decimales es " + Math.Round(numero, 2));
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
    }
}
