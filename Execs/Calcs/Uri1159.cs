using System;
using System.Globalization;

namespace Execs
{
    class Uri1159
    {
        public static void somaPares()
        {
            int x, num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0;
            x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                if (x % 2 == 0)
                {
                    num1 = x;
                    num2 = num1 + 2;
                    num3 = num2 + 2;
                    num4 = num3 + 2;
                    num5 = num4 + 2;
                    var resultado = num1 + num2 + num3 + num4 + num5;
                    Console.WriteLine(resultado);
                }
                else
                {
                    num1 = x + 1;
                    num2 = num1 + 2;
                    num3 = num2 + 2;
                    num4 = num3 + 2;
                    num5 = num4 + 2;
                    var resultado = num1 + num2 + num3 + num4 + num5;
                    Console.WriteLine(resultado);
                }
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}