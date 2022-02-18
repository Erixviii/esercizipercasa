using System;

namespace Es3_classi_statiche
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertToBool.StoB("true"));
            Console.WriteLine(ConvertToBool.BtoS(true));
            Console.WriteLine(ConvertToBool.ItoB(11));
            Console.WriteLine(ConvertToBool.BtoI(true));
        }
    }
    static class ConvertToBool
    {
        public static bool StoB(string s)
        {
            try
            {
                return Convert.ToBoolean(s);
            }
            catch
            {
                return false;
            }
        }
        public static string BtoS(bool b)
        {
            try
            {
                return b.ToString();
            }
            catch
            {
                return "non valid";
            }
        }

        public static bool ItoB(int i)
        {
            if (i == 0) return false;
            else return true;
        }

        public static int BtoI(bool b)
        {
            if (b == true) return new Random().Next(0,11);
            else return 0;
        }
    }
}
//Si definisca una classe statica  che senza
//bisogno di creare istanze offra i seguenti metodi statici: 1.Conversione da string a bool; 2.Conversione da bool a
//string; 3.Conversione da int a bool (zero vale falso, il resto a true); 4.Conversione da bool a int (falso rende zero,
//altrimenti uno);