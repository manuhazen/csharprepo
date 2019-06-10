using System;
using CoreScuela.Entidades;

namespace Etapa_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("ITESA", 1930, TipoDeEscuela.Secundaria, city: "Santo Domingo", country: "Dominican Republic");
            var curso = new Curso()
            {
                Name = "301"
            };
            Console.WriteLine(escuela);
        }

        private static void PrintCourses(Curso[] courses)
        {
            foreach (Curso c in courses)
            {
                Console.WriteLine($"Nombre: {c.Name}, ID: {c.UniqueID}");
            }
        }
    }
}
