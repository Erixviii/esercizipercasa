using static System.Console;

namespace esercizio1
{
    class Persona
    {
        private string _nome;
        private string _cognome;
        private int _eta;
        private string _sesso;

        public Persona(string nome = "", string cognome = "", int eta = 1, string sesso = "")
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
            Sesso = sesso;
        }

        public string Nome { get => _nome; set { if (value.Equals("")) { _nome = "(nessun nome)"; } else { _nome = value; } } }
        public string Cognome { get => _cognome; set { if (value.Equals("")) { _cognome = "(nessun nome)"; } else { _cognome = value; } } }
        public int Eta
        {
            get => _eta; set
            {
                if (value > 0 && value <= 110 && int.TryParse(value.ToString(), out _eta))
                {

                }
                else
                {
                    _eta = 1;
                    WriteLine("valore errato, dato non modificato ");
                }
            }
        }
        public string Sesso { get => _sesso; set => _sesso = value; }

        public void StampaMessaggio()
        {
            WriteLine("Ho stampato quanto richiesto");
        }

        public void Saluti()
        {
            WriteLine("Ciao ciao");
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\n" +
                   $"Cognome: {Cognome}\n" +
                   $"età: {Eta}"
                   ;
        }
    }
}
