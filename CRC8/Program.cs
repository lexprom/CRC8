using System;
using System.IO;

namespace CRC8
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var stream = new FileStream("input.txt", FileMode.Open))
            {
                byte result = CRC8.Calculate(stream);
                Console.WriteLine(result);
            }
        }
    }
}
