using System;

namespace Execs
{
    class Uri1131
    {
        public static void Grenais()
        {
            string[] valores = Console.ReadLine().Split(' ');
            int golsInter, golsGremio, novoGrenal = 1,
            qnttGrenais = 0, qnttVitInter = 0, qnttVitGremio = 0,
            qttEmpates = 0;
            golsInter = int.Parse(valores[0]);
            golsGremio = int.Parse(valores[1]);

            while (novoGrenal == 1)
            {
                if (golsInter > golsGremio)
                {
                    qnttVitInter++;
                }
                else if (golsGremio > golsInter)
                {
                    qnttVitGremio++;
                }
                else
                {
                    qttEmpates++;
                }
                qnttGrenais++;
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoGrenal = int.Parse(Console.ReadLine());
                if (novoGrenal == 1)
                {
                    valores = Console.ReadLine().Split(' ');
                    golsInter = int.Parse(valores[0]);
                    golsGremio = int.Parse(valores[1]);
                }
            }

            Console.WriteLine($"{qnttGrenais} grenais");
            Console.WriteLine($"Inter:{qnttVitInter}");
            Console.WriteLine($"Gremio:{qnttVitGremio}");
            Console.WriteLine($"Empates:{qttEmpates}");
            if (qnttVitInter > qnttVitGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else
            {
                Console.WriteLine("Gremio venceu mais");
            }
        }
    }
}