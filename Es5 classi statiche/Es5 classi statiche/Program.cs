using System;

namespace Es5_classi_statiche
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convertitore.ItoBin(8));
        }
    }

    static class Convertitore
    {
        public static string ItoBin(int i)
        {
            return Convert.ToString(i, 2);
        }
    }
}
//CONVERTITORE Si definisca una classe statica Convertitore che senza bisogno
//di creare istanze, definisca metodi statici che rappresentano: 1.Conversione da intero(sistema decimale) a intero
//(sistema binario) 2.Conversione da intero(sistema decimale) a intero(sistema ottale) 3.Conversione da intero
//(sistema decimale) a intero(sistema esadecimale) 4.Conversione da intero(sistema binario) a intero(sistema
//decimale) 5.Conversione da intero(sistema ottale) a intero(sistema decimale) 6.Conversione da intero(sistema
//esadecimale) a intero(sistema decimale)
