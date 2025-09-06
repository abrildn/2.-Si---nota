using System;

namespace Doss
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la nota del alumno");
            string linea = Console.ReadLine();
            float nota = float.Parse(linea);

            float siete = 7;
            if (nota >= siete)
            {
                Console.WriteLine("Promocionado");
            }
            else
            {
                Console.WriteLine("Desaprobado");
            }
            Console.ReadKey();
        }
    }
}
