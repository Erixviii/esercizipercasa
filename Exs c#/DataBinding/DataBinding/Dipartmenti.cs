using System.Collections.Generic;
namespace DataBinding
{
    class Dipartimenti
    {
        public List<Studente> Studenti { get; set; }
        public string Nome { get; set; }
        public Dipartimenti(string nome)
        {
            Nome = nome;

            Studenti = new List<Studente>();
        }
    }
}
