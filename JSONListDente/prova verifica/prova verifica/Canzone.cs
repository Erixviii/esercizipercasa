namespace prova_verifica
{
    class Canzone
    {
        public Canzone(string id, string nomeCanzone, string anno)
        {
            Id = id;
            NomeCanzone = nomeCanzone;
            AnnoProduzione = anno;
        }

        public string Id { get; set; }
        public string NomeCanzone { get; set; }
        public string AnnoProduzione { get; set; }
    }
}
