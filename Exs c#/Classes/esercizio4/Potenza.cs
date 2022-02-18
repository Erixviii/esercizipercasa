using static System.Console;

namespace esercizio4
{
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

        public static Potenza operator *(Potenza p1, Potenza p2)
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
