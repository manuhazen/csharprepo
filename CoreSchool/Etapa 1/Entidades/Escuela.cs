namespace CoreScuela.Entidades
{
    class Escuela
    {
        public string Name { get; set; }
        public int Founded { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        // public Escuela(string name, int founded)
        // {
        //     Name = name;
        //     Founded = founded;
        // }

        public Escuela(string name, int founded, string city, string country) => (Name, Founded, City, Country) = (name, founded, city, country);
    }
}