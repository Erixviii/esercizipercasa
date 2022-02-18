namespace Clinica_Dente
{
    class Medico : Paziente
    {
        
        public override string Patologia { get => Specializzazione; set => Specializzazione = value; }
        public string Specializzazione { get; set; }
    }
}
