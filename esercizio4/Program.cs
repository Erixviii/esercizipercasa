using System;
using static System.Console;

namespace esercizio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Potenza p = new Potenza();
            WriteLine("Inserisci la prima base");
            p.Base = int.Parse(ReadLine());
            WriteLine("Inserisci la seconda base");
            p.Base = int.Parse(ReadLine());
        }
    }

    class Potenza
    {
        private int _base;
        private int _esponente;

        public Potenza()
        {
            Base = 0;
            Esponente = 0;
        }

        public Potenza(int @base, int esponente)
        {
            Base = @base;
            Esponente = esponente;
        }

        public int Base { get => _base; set
            {
                if (value > 0 && int.TryParse(value.ToString(), out _base)) { }
                else
                {
                    _base = 1;
                    WriteLine("valore errato, base negativa o non numerica");
                }
            }
        }

        public int Esponente
        {
            get => _esponente; set
            {
                if (value > 0 && int.TryParse(value.ToString(), out _esponente)) { }
                else
                {
                    _esponente = 1;
                    WriteLine("valore errato, esponente negativo o non numerico" +
                        "");
                }
            }
        }

        public override string ToString()
        {
            return $" {Base}^{Esponente} ";
        }
    }
}
