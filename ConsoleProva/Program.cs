using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProva
{
    class Program
    {
        static void Main(string[] args)
        {
            const string TEXT = "Xhali";
            Console.BackgroundColor = ConsoleColor.Magenta;
            for (int x = 0; x < int.MaxValue; x++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(TEXT);

                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(TEXT);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write(TEXT);
            }
        }
    }
}
