using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ChatGPT_Herencia_Personal
{
    class Program
    {
        static void Main(string[] args)
        {
            Profesor profesor01 = new Profesor(16620902, "Pedro", "Gezzi", "Loyola 2025");
            Profesor profesor02;
            profesor02 = new Profesor(24603259, "Augusto", "Bayly", "Chacabuco 560");
            Profesor profesor03;
            profesor03 = new Profesor();
            profesor03.Id = 6525823;
            profesor03.Nombre = "Julieta";
            profesor03.Apellido = "Sanchez";
            profesor03.Direccion = "Pietra 294";

            // Atributos de los objetos expresados en cadena de caracteres.
            Console.WriteLine("Presione una tecla y mostraré los objetos en cadena de caracteres...");
            Console.ReadLine();
            Console.WriteLine(profesor01.ToString());
            Console.WriteLine(profesor02.ToString());
            Console.WriteLine(profesor03.ToString());
            Console.WriteLine(" | ---------------------------------------------------------------------------");
            Console.ReadLine() ;
        }
    }
}
