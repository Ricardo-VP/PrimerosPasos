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
            Console.WriteLine();
            float sueldo, egreso, total;
            Console.Write("Ingresa el sueldo del trabajador: ");
            sueldo = float.Parse(Console.ReadLine());

            Console.Write("Ingresa los gastos del trabajador: ");
            egreso = float.Parse(Console.ReadLine());

            total = sueldo - egreso;
            Console.WriteLine("El liquido a recibir es: {0} ",total);

            //Tipo de dato: Flotante de doble precisión
            Console.WriteLine();
            double x1 = 200.5679;
            Console.WriteLine("Tipo de dato double: {0}", x1);

            //Tipo de dato: Cadena de caracteres
            Console.WriteLine();
            string nombre;
            Console.Write("Ingresa tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + " bienvenido al curso de programación ");

            //Tipo de dato booleano (tipo lógico: verdadero/falso) (true/false)
            Console.WriteLine();
            bool sw;
            sw = (a+50) > b;
            Console.WriteLine("El valor del booleano sw: {0}", sw);


            //Ejecución de sentencias secuenciales
            //Uso de estructuras repetitivas
            //Uso de estructuras selectivas

            saludos(nombre);
            saludos("Ricardo");
            saludos("Enrique");

            Console.WriteLine();

            Console.WriteLine("Llamada a función que devuelve valor: ");
            Console.WriteLine("Liquido a recibir para Juan {0}", calcularSueldo(300, 200));
            Console.WriteLine("Liquido a recibir para Carlos {0}", calcularSueldo(2000, 1000));
            Console.WriteLine("Liquido a recibir para Jhon {0}", calcularSueldo(1340, 199));


            Console.ReadKey();
        }   //Fin del MAIN

        //Funciones: subprocesos - subprogramas - subrutinas
        //Dividir el código en módulos
        //Podemos reutilizar el código  
        //Tipo: devuelven valores - no devuelven valores

        static void saludos(string nombre) //Parámetro - Argumento
        {
            Console.WriteLine("Función que no devuelve valores...");
            Console.WriteLine("Hola {0}",nombre);
        }

        //Función que devuelve valor
        //La función devuelve un tipo de dato
        
        static int calcularSueldo(int ingreso, int egreso)
        {
            return (ingreso-egreso);
        }
    }
}
