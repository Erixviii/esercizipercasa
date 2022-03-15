using System.Collections.Generic;

namespace prova_verifica
{
    class Cantante
    {
        public Cantante(string id, string nomeCantante, string nomeArte, string nazionalità)
        {
            Id = id;
            NomeCompleto = nomeCantante;
            NomeArte = nomeArte;
            Nazionalità = nazionalità;
            LSTCanzoni = new List<Canzone>();
        }

        public string Id { get; set; }
        public string NomeCompleto { get; set; }
        public string NomeArte { get; set; }
        public string Nazionalità { get; set; }

        public List<Canzone> LSTCanzoni { get; set; }
    }
}
