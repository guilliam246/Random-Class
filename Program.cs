using System;

namespace Random_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            for (int i = 0; i < 10; i++)
                Console.Write((char)('a' + random.Next(0, 26)));
            Console.WriteLine();
        }
    }
}
