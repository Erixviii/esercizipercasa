using System;
using static System.Console;

namespace esercizio
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona eric = new Persona();
            WriteLine("prova_Classi.Persona");
            WriteLine(eric.ToString());
            WriteLine("prova_Classi.Persona");
            WriteLine("Ora utilizzo la proprietà per modificare il nome");
            eric.Nome = "";
            WriteLine($"Nuovo nome: {eric.Nome}");
            eric.Nome = "Eric";
            WriteLine($"Nuovo nome: {eric.Nome}");
            eric.Eta = 120;
            WriteLine($"eta: {eric.Eta}");
            eric.Eta = 0;
            WriteLine($"eta: {eric.Eta}");
            eric.Eta = -5;
            WriteLine($"eta: {eric.Eta}");
            eric.Eta = 20;
            WriteLine($"eta: {eric.Eta}");
            eric.StampaMessaggio();
            eric.Saluti();
        }
    }

    class Persona
    {
        private string _nome;
        private string _cognome;
        private int _eta;
        private string _sesso;

        public Persona()
        {
            _nome="";
            _cognome="";
            _eta=0;
            _sesso="";
        }

        public string Nome { get => _nome; set { if (value.Trim().Equals("")) { _nome = "(nessun nome)"; } } }
        public string Cognome { get => _cognome; set { if (value.Trim().Equals("")) { _cognome = "(nessun nome)"; } } }
        public int Eta { get => _eta; set
            {
                if (value > 0 && value <= 110 && int.TryParse(value.ToString(), out _eta))
                {

                }
                else {
                    _eta = 1;
                    WriteLine("valore errato, dato non modificato ");
                     }
            } }
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
                   $"Cognome: {Cognome}"
                   ;
        }

    }
}
