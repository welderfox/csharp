using System;
using System.Globalization;

namespace Execs
{
    class Uri1154
    {
        public static void mediaIdade()
        {
            double idade, soma = 0.0, cont = 0.0, media;
            idade = double.Parse(Console.ReadLine());

            while (idade >= 0)
            {
                soma = soma + idade;
                cont++;
                idade = int.Parse(Console.ReadLine());
            }
            media = soma / cont;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}