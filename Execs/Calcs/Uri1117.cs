using System;
using System.Globalization;

namespace Execs
{
    class Uri1117
    {
        public static void mediaNotas()
        {
            double nota1, nota2, media, soma = 0.0;
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (nota1 < 0.0 || nota1 > 10.0)
            {
                Console.WriteLine("nota invalida");
                nota1 = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);
            }
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (nota2 < 0.0 || nota2 > 10.0)
            {
                Console.WriteLine("nota invalida");
                nota2 = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);
            }
            soma = nota1 + nota2;
            media = soma / 2;
            Console.WriteLine($"media = {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}