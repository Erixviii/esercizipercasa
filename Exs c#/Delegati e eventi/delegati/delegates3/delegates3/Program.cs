using System;

namespace delegates3
{
    class Program
    {
        public delegate void Del(double a1, double a2);
        static void Main(string[] args)
        {
            double num1 = 3.4;
            double num2 = 5.7;
            Del delegato = new Del(Somma);
            delegato += Sottrazione;
            delegato += Moltiplicazione;
            delegato += Divisione;
            delegato(num1, num2);

        }

        public static void Somma(double a1, double a2)
        {
            Console.WriteLine($"la somma è {a1 + a2}");
        }
        public static void Sottrazione(double a1, double a2)
        {
            Console.WriteLine($"la sottrazione è {a1 - a2}");
        }
        public static void Moltiplicazione(double a1, double a2)
        {
            Console.WriteLine($"la moltiplicazione è {a1 * a2}");
        }
        public static void Divisione(double a1, double a2)
        {
            Console.WriteLine($"la divisione è {a1 / a2}");
        }
    }
}
