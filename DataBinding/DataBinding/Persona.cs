namespace DataBinding
{
    class Persona
    {
        public Persona(int id, string nome, string cognome)
        {
            Id = id;
            Nome = nome;
            Cognome = cognome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Nomecompleto { get => $"{Nome} {Cognome}"; set => Nomecompleto = value; }
    }
}
