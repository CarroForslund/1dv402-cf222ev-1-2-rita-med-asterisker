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
            for (int i = 0; i < 25; i++) // rader
            {
                for (int j = 0; j < 39; j++) // kolumner
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                if (i % 2 == 0) // för jämna tal
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
