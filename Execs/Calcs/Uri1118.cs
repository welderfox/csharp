using System;
using System.Globalization;

namespace Execs
{
    class Uri1118
    {
        public static void mediaNotaComValidacao()
        {
            double nota1, nota2, media;
            int x = 1;

            while (x == 1)
            {
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (nota1 < 0 || nota1 > 10)
                {
                    Console.WriteLine("nota invalida");
                    nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (nota2 < 0 || nota2 > 10)
                {
                    Console.WriteLine("nota invalida");
                    nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                media = (nota1 + nota2) / 2;
                Console.WriteLine($"media = {media.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                x = int.Parse(Console.ReadLine());
                while (x != 1 && x != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    x = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}