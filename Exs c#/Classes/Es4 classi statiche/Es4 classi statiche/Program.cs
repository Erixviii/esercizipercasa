using System;

namespace Es4_classi_statiche
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CambiaValuta.DollaroToEuro(1)); 
            Console.WriteLine(CambiaValuta.EuroToDollaro(1));
            Console.WriteLine(CambiaValuta.LiraToEuro(1));
            Console.WriteLine(CambiaValuta.EuroToLira(1));
        }
    }

    static class CambiaValuta
    {
        public static double Dollaro {
            get => Lira; set
            {
                Dollaro = value;
                Euro = DollaroToEuro(Dollaro);
                Lira = EuroToDollaro(Euro);
            }
        }
        public static double Euro {
            get => Euro; set
            {
                Euro = value;
                Lira = EuroToLira(Euro);
                Dollaro = EuroToDollaro(Euro);
            }
        }
        public static double Lira { get=>Lira; set 
            { 
                Lira = value;
                Euro = LiraToEuro(Lira);
                Dollaro = EuroToDollaro(Euro);
            }
        }

        static public  double DollaroToEuro(double d)
        {
            return d * 0.88;
        }
        static public double EuroToDollaro(double e)
        {
            return e * 1.13;
        }

        static public double LiraToEuro(double l)
        {
            return l * 0.0005;
        }

        static public double EuroToLira(double l)
        {
            return l * 1936.270;
        }
    }
}