using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1_RAMS_1018822
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");
            Console.WriteLine("soy RUDY");
            Console.ReadKey();

            /*COMENTARIOS*/

            Console.WriteLine("Hola Mundo soy RUDY");
            Console.ReadKey();  

            Console.WriteLine("Ingrese su nombre: ");
            string Nombre = Console.ReadLine();
            
            Console.WriteLine("Hola Mundo");
            Console.WriteLine("soy " + Nombre);

            /*COMENTARIOS*/

            Console.Write("Hola Mundo ");
            Console.Write("soy " + Nombre);
            Console.ReadLine();


            Console.WriteLine("");

            Console.Write("Nombre: ");
            string sNombre = Console.ReadLine();;

            Console.Write("Edad: ");
            string sEdad = Console.ReadLine();

            Console.Write("Carrera: ");
            string sCarrera = Console.ReadLine();

            Console.Write("Carne: ");
            string sCarne = Console.ReadLine();

            Console.Write("Soy " + sNombre + ", tengo " + sEdad + " años y estudio la carrera de " + sCarrera + ". Mi nùmero de carnè es; " + sCarne);
            Console.ReadLine();
        }
    }
}
