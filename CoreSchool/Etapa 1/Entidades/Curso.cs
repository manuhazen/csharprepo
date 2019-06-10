using System;

namespace CoreScuela.Entidades
{
    public class Curso
    {
        public string UniqueID { get; private set; }
        public string Name { get; set; }
        public Jornada Shift { get; set; }

        public Curso()
        {
            UniqueID = Guid.NewGuid().ToString();
        }
    }
}