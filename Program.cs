using System;

namespace Random_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            const int passwordlength = 20;

            var buffer = new char[passwordlength];
            for (int i = 0; i < passwordlength; i++)

                buffer[i] = (char)('a' + random.Next(0, 26));

            var password = new string(buffer);

            Console.WriteLine(password);
        }
    }
}
