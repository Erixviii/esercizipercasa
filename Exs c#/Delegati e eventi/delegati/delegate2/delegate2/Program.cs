using System;

namespace delegate2
{
    public delegate int Del(int i);
    class Program
    {
        static void Main(string[] args)
        {
            int num = 4;
            Del delegato = new Del(Calcolo);
        
            delegato(num);
        }

        public static int Calcolo(int s)
        {
            Console.WriteLine($"il quadrato di {s} è {s * s}");
            Calcolo2(s * s);
            return s * s;
            
        }
        public static int Calcolo2(int s)
        {
            Console.WriteLine($"il cubo di {s} è {s * s * s}");
            return s * s * s;

        }
    }
}
