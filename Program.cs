using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_rita_med_asterisker_a
{
    class Program
    {
        static void Main(string[] args)
        {
            // Beräkna och skriv ut mönster
            // 39 kolumner och 25 rader
            // Varannan rad börjar med ett indrag
            // Var tredje rad är grön, magenta respektive gul
            for (int rowNumber = 0; rowNumber < 25; rowNumber++) 
            {
                for (int columnNumber = 0; columnNumber < 39; columnNumber++)
                {
                    switch (rowNumber % 3)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        default :
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                    }
                    Console.Write("* ");
                }
                Console.WriteLine();
                if (rowNumber % 2 == 0) // för jämna tal
                {
                    Console.Write(" ");
                }
            }
        }
    }
}