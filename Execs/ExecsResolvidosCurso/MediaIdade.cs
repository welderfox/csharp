using System;
using System.Globalization;

namespace Execs
{
    class MediaIdade
    {
        public static void Media()
        {
            int idade;
            double media = 0;
            double qntIdade = 0;
            int idades = 0;

            idade = int.Parse(Console.ReadLine());
            if (idade < 0)
            {
                Console.WriteLine("impossivel calcular");
            }
            else
            {
                while (idade >= 0)
                {
                    idades = idades + idade;
                    qntIdade++;
                    idade = int.Parse(Console.ReadLine());
                }
                media = idades / qntIdade;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }

        }


    }
}