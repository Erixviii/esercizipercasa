namespace Clinica_Dente
{
    class Paziente
    {

        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string email { get; set; }
        virtual public string Patologia { get; set; }
        public int Id { get; set; }
    }
}
