using System;
using static System.Console;

namespace esercizio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Potenza p1 = new Potenza();
            WriteLine("Inserisci la prima base");
            int risposta;
            while (!int.TryParse(ReadLine(), out risposta))
            {
                WriteLine("Inserisci un valore corretto");
            }
            p1.Base = risposta;
            WriteLine("Inserisci il primo esponente");
            while (!int.TryParse(ReadLine(), out risposta))
            {
                WriteLine("Inserisci un valore corretto");
            }
            p1.Esponente = risposta;

            Potenza p2 = new Potenza();
            WriteLine("Inserisci la seconda base");
            while (!int.TryParse(ReadLine(), out risposta))
            {
                WriteLine("Inserisci un valore corretto");
            }
            p2.Base = risposta;
            WriteLine("Inserisci il secondo esponente");
            while (!int.TryParse(ReadLine(), out risposta))
            {
                WriteLine("Inserisci un valore corretto");
            }
            p2.Esponente = risposta;

            WriteLine(p1.ToString() + " * " + p2.ToString() + " = " + Op_asterisco(p1, p2).ToString());

            Potenza Op_asterisco(Potenza p1,Potenza p2)
            {
                Potenza p3 = new Potenza(p1.Base, p1.Esponente);

                if (p1.Base == p2.Base)
                {

                    p3.Esponente = p1.Esponente + p2.Esponente;
                }
                else
                {
                    p3.Base = (p1.Base ^ (p1.Esponente)) * (p2.Base ^ (p2.Esponente));
                    p3.Esponente = 1;
                }

                if (p1.Esponente == p2.Esponente)
                {

                    p3.Base = p1.Base * p2.Base;
                    p3.Esponente = p1.Esponente;
                }

                return p3;
            }

            Potenza Op_slash(Potenza p1, Potenza p2)
            {
                Potenza p3 = new Potenza(p1.Base, p1.Esponente);

                if (p1.Base == p2.Base)
                {

                    p3.Esponente = p1.Esponente - p2.Esponente;
                }

                if (p1.Esponente == p2.Esponente)
                {

                    p3.Base = p1.Base / p2.Base;
                    p3.Esponente = p1.Esponente;
                }

                return p3;
            }
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
                if (value >= 0 ) { _base = value; }
                else
                {
                    _base = 1;
                    WriteLine("valore errato, base negativa");
                }
            }
        }

        public static Potenza Moltiplica(Potenza p1, Potenza p2)
        {
            Potenza p3 = new Potenza(p1.Base, p1.Esponente);

            if (p1.Base == p2.Base)
            {

                p3.Esponente = p1.Esponente + p2.Esponente;
            }

            if (p1.Esponente == p2.Esponente)
            {

                p3.Base = p1.Base * p2.Base;
                p3.Esponente = p1.Esponente;
            }

            return p3;
        }

        public int Esponente
        {
            get => _esponente; set
            {
                if (value >= 0) { _esponente = value; }
                else
                {
                    _esponente = 1;
                    WriteLine("valore errato, esponente negativo");
                }
            }
        }

        public override string ToString()
        {
            return $"{Base}^{Esponente}";
        }
    }
}
