using System;

namespace esercizio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Persona
    {
        private string _nome;
        private string _cognome;
        private int _eta;
        private char _sesso;

        public Persona()
        {

        }

        public string Nome { get => _nome; set => _nome = value; }
        public string Cognome { get => _cognome; set => _cognome = value; }
        public int Eta { get => _eta; set => {
                if (value != 0 && int.TryParse(value, out _eta))
                {
                }
                else
                    MessageBox.Show("Error ") ;
            } }
        public char Sesso { get => _sesso; set => _sesso = value; }
    }
}
