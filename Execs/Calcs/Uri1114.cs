using System;
using System.Globalization;

namespace Execs
{
    class Uri1114
    {
        public static void TestadorDeSenha()
        {
            int senha;
            senha = int.Parse(Console.ReadLine());
            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}