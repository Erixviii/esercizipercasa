using System.Collections.Generic;

namespace prova_verifica
{
    class GenereMusica
    {
        public GenereMusica(string sigla, string nomeGenere)
        {
            Sigla = sigla;
            NomeGenere = nomeGenere;
            LSTCantanti = new List<Cantante>();
        }

        public string Sigla { get; set; }
        public string NomeGenere { get; set; }

        public List<Cantante> LSTCantanti { get; set; }
    }
}
