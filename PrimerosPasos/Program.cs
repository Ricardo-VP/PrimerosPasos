using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerosPasos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipos de datos
            int a, b, suma; //Declarar variable tipo entero
            a = 10;
            b = 20;
            suma = a + b;
            Console.WriteLine("La suma de {0} + {1} = {2}", a, b, suma);

            //Tipo de dato: Número en coma flotante
            float sueldo, egreso, total;
            Console.Write("Ingresa el sueldo del trabajador: ");
            sueldo = float.Parse(Console.ReadLine());

            Console.Write("Ingresa los gastos del trabajador: ");
            egreso = float.Parse(Console.ReadLine());

            total = sueldo - egreso;
            Console.WriteLine("El liquido a recibir es: {0} ",total);

            //Tipo de dato: Flotante de doble precisión
            double x1 = 200.5679;
            Console.WriteLine("Tipo de dato double: {0}", x1);

            //Tipo de dato: Cadena de caracteres
            string nombre;
            Console.Write("Ingresa tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + " bienvenido al curso de programación ");

            //Tipo de dato booleano (tipo lógico: verdadero/falso) (true/false)
            bool sw;
            sw = (a+50) > b;
            Console.WriteLine("El valor del booleano sw: {0}", sw);


            Console.ReadKey();
        }
    }
}
