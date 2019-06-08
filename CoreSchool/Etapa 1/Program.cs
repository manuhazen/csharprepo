using System;
using CoreScuela.Entidades;

namespace Etapa_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("ITESA", 1930, "Bogota", "Colombia");
            Console.WriteLine(escuela.Name);
        }
    }
}
