using System;
using CoreScuela.Entidades;
using static System.Console;
namespace Etapa_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("ITESA", 1930, TipoDeEscuela.Secundaria, city: "Santo Domingo", country: "Dominican Republic");
            escuela.Courses = new Curso[] {
                new Curso(){ Name = "301"},
                new Curso(){ Name = "201"},
                new Curso(){ Name = "101"},
            };
            escuela.Courses = null;
            WriteLine(escuela);
            WriteLine("=====================================");
            PrintCourses(escuela.Courses);
        }

        private static void PrintCourses(Escuela escuela)
        {
            if (escuela?.Courses != null)
            {
                foreach (Curso c in escuela.Courses)
                {
                    WriteLine($"Nombre: {c.Name}, ID: {c.UniqueID}");
                }
            }

        }
    }
}
