using System;

namespace delegates6
{
    class Cliente
    {
        private string _Nome;
        private string _Cognome;
        private string _Indirizzo;
        private double _Saldo;

        public event EventHandler Errore;

        public Cliente(string nome, string cognome, string indirizzo)
        {
            _Nome = nome;
            _Cognome = cognome;
            _Indirizzo = indirizzo;
            _Saldo = 0;
        }
        public void Versamento(double imp)
        {

            _Saldo += imp;
        }
        public void Prelevamento(double imp)
        {
            if (imp > _Saldo)
                Errore(this, new EventArgs());
            else
                _Saldo -= imp;
        }
        public double VisualizzaSaldo()
        {
            return _Saldo;
        }
    }
}
