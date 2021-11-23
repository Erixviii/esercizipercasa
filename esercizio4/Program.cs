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

            int calcolopotenza(Potenza p)
            {
                int c=1;

                for (int i = 0; i < p.Esponente; i++)
                {
                    c = c * p.Base;
                }

                return c;
            }

            Potenza Op_asterisco(Potenza p1,Potenza p2)
            {
                Potenza p3 = new Potenza(p1.Base, p1.Esponente);

                if (p1.Base == p2.Base)
                {

                    p3.Esponente = p1.Esponente + p2.Esponente;
                }
                else
                {
                    p3.Base = calcolopotenza(p1) * calcolopotenza(p2);
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
                else
                {
                    p3.Base = calcolopotenza(p1) / calcolopotenza(p2);
                    p3.Esponente = 1;
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
}
