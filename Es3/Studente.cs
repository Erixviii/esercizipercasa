namespace esercizio3
{
    class Studente : Persona
    {
        private string _matricola;
        public Studente(string matricola, string nome = "", string cognome = "", int eta = 1, string sesso = "") : base(nome, cognome, eta, sesso)
        {
            Matricola = matricola;
        }
        public string Matricola {
            get => _matricola;
            set {
                if (value == "")
                {
                    _matricola = "(nessuna matricola)";
                } else {
                    _matricola = value;
                }
            }
        }
        public override string ToString()
        {
            return $"{ base.ToString() }\nMatricola: {Matricola}";
        }
    }
}