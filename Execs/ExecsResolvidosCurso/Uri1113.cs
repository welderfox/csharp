using System;
using System.Globalization;

namespace Execs
{
    class Uri1113
    {

        public static void AscendingDescending()
        {
            string[] valores = Console.ReadLine().ToString().Split(' ');
            int x, y;
            x = int.Parse(valores[0]);
            y = int.Parse(valores[1]);

            while (x != y)
            {
                if (x < y)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }
                valores = Console.ReadLine().ToString().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
            }
        }
    }
}