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
            string numero;
            bool Flag = false;
            decimal Salida=0;
            do
            {
                Console.WriteLine("Ingrese un número con decimales");
                numero = Console.ReadLine();
                if (!decimal.TryParse(numero, out Salida))
                {
                    Console.WriteLine("Usted debe ingresar un número");
                }
                else
                {
                    Flag = true;
                    Console.WriteLine($"El número ingresado es {numero} \r\n" +
                    "y el número redondeado en dos decimales es " + Math.Round(Salida, 2));
                    Console.WriteLine("Presione una tecla para salir");
                }
            } while (Flag==false);
            
            Console.ReadKey();
        }
    }
}
