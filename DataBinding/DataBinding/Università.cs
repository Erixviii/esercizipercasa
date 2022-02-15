using System.Collections.Generic;
namespace DataBinding
{
    class Università
    {
        public Università(string Sigla, string Nome, string Indirizzo)
        {
            _Sigla = Sigla;
            _Nome = Nome;
            _Indirizzo = Indirizzo;
            Dipartimenti = new List<Dipartimenti>();
        }

        public string _Sigla { get; set; }
        public string _Nome { get; set; }
        public string _Indirizzo { get; set; }
        public List<Dipartimenti> Dipartimenti { get; set; }
    }
}
