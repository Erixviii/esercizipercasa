using System;

namespace Es1_classi_statiche
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RandomInt.Next());
            Console.WriteLine(RandomInt.Next(100));
            Console.WriteLine(RandomInt.Next(0,10));
        }
    }

    static class RandomInt
    {
        private static Random num;

        public static int Next()
        {

            num = new Random();
            return num.Next();
        }
        public static int Next(int maxValue)
        {

            num = new Random();
            return num.Next(maxValue);
        }
        public static int Next(int minValue, int maxValue)
        {

            num = new Random();
            return num.Next(minValue,maxValue);
        }
    }
}