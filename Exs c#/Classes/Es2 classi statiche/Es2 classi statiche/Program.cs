using System;

namespace Es2_classi_statiche
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RandomDouble.Next());
        }
    }

    static class RandomDouble
    {
        private static Random num;

        public static double Next()
        {

            num = new Random();
            return num.NextDouble();
        }
    }
}