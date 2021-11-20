using System;
using static System.Console;

namespace esercizio3
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

            Studente eric2 = new Studente("4079753");
            eric2.Nome = "Eric";
            WriteLine($"nome studente: {eric2.Nome}");
            eric2.Cognome = "Dente";
            WriteLine($"cognome studente: {eric2.Cognome}");
            eric2.Eta = 18;
            WriteLine($"età studente: {eric2.Eta}");
            WriteLine($"età studente: {eric2.Matricola}");
        }
    }

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
    class Studente : Persona
    {
        private string _matricola;

        public Studente(string matricola)
        {
            Matricola = matricola;
        }

        public string Matricola { get => _matricola; set { if (value.Equals("")) { _matricola = "(nessuna matricola)"; } else { _matricola = value; } } }

        public override string ToString()
        {
            return base.ToString() + $"\nmatricola: {Matricola}";
        }
    }
}

