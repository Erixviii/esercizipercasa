using System.Collections.Generic;
namespace DataBinding
{
    class Dipartimenti
    {
        public List<Studente> Studenti { get; set; }
        public string _NomeDipartimento { get; set; }
        public Dipartimenti(string NomeDipartimento)
        {
            _NomeDipartimento = NomeDipartimento;

            Studenti = new List<Studente>();
        }
    }
}
