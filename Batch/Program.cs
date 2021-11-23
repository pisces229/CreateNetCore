using System;
using ClassLib.First;
using ClassLib.Second;

namespace Batch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- Batch ----------");
            new ClassLibFirst();
            new ClassLibSecond();
        }
    }
}
