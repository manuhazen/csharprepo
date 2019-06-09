using System;
using CoreScuela.Entidades;

namespace Etapa_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("ITESA", 1930, TipoDeEscuela.Secundaria, city: "Santo Domingo", country: "Dominican Republic");
            escuela.Type = TipoDeEscuela.Primaria;
            Console.WriteLine(escuela);
        }
    }
}
