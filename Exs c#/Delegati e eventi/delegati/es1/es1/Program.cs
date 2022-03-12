using System;

namespace es1
{
    class Program
    {

        public delegate void CMP(int a);
        public CMP delegato;
        static void Main(string[] args)
        {
            Program main = new Program();
            int[] array = new int[] { 1, 2, 0, -3 };

            main.delegato += CMPout;

            foreach (int n in array)
                main.delegato(n);

        }

        public static void CMPout(int a)
        {
            if (a > 0)
                Console.WriteLine(a + " è positivo");
            else if (a == 0)
                Console.WriteLine(a + " è uguale a 0");
            else if (a < 0)
                Console.WriteLine(a + " è negativo");
        }
    }
}
