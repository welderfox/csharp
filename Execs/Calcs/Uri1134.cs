using System;
using System.Globalization;

namespace Execs
{
    class Uri1134
    {
        public static void productRate()
        {
            int codigo, alcool = 0, gasolina = 0, diesel = 0;
            codigo = int.Parse(Console.ReadLine());

            while (codigo != 4)
            {
                if (codigo > 4)
                {
                    codigo = int.Parse(Console.ReadLine());
                }
                else
                {
                    if (codigo == 1)
                    {
                        alcool++;
                    }
                    else if (codigo == 2)
                    {
                        gasolina++;
                    }
                    else
                    {
                        diesel++;
                    }
                    codigo = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}