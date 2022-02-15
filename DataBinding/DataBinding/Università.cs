using System.Collections.Generic;
namespace DataBinding
{
    class Università
    {
        public Università(string sigla, string nome, string indirizzo)
        {
            Sigla = sigla;
            Nome = nome;
            Indirizzo = indirizzo;
            Dipartimenti = new List<Dipartimenti>();
        }

        public string Sigla { get; set; }
        public string Nome { get; set; }
        public string Indirizzo { get; set; }
        public List<Dipartimenti> Dipartimenti { get; set; }
    }
}
