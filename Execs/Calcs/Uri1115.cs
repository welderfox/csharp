using System;
using System.Globalization;

namespace Execs
{
    class Uri1115
    {
        public static void QuadrantesWhile()
        {
            string[] valores = Console.ReadLine().Split(' ');
            int x, y;
            x = int.Parse(valores[0]);
            y = int.Parse(valores[1]);
            while (x != 0 && y != 0)
            {
                if (x >= 1 && y >= 1)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y >= 1)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }
                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
            }
        }
    }
}