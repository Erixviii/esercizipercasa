namespace DataBinding
{
    class Studente
    {
        public string Nome { get; set; }
        public string Indirizzo { get; set; }
        public Studente(string nome, string indirizzo)
        {
            Nome = nome;
            Indirizzo = indirizzo;
        }
    }
}
