namespace CoreScuela.Entidades
{
    class Escuela
    {
        public string Name { get; set; }
        public int Founded { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public TipoDeEscuela Type { get; set; }

        // public Escuela(string name, int founded)
        // {
        //     Name = name;
        //     Founded = founded;
        // }
        public Escuela(string name, int founded, TipoDeEscuela type, string city = "", string country = "")
        {
            (Name, Founded) = (name, founded);
            City = city;
            Country = country;
        }

        public override string ToString()
        {
            return $"Nombre: {Name}, Tipo: {Type} \nPais: {Country}, Ciudad: {City} \n";
        }
    }
}