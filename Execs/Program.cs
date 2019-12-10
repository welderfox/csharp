using System;
using System.Globalization;

namespace Execs
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("Qual é a cotação do dólar? ");
      ConversorDeMoeda.CotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Quantos dólares você quer comprar? ");
      ConversorDeMoeda.ValorAConverter = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      double cotacao = ConversorDeMoeda.CotacaoDolar;
      double aConverter = ConversorDeMoeda.ValorAConverter;
      Console.Write($"Valor a ser pago em reais = "
      + $"{ConversorDeMoeda.Convercao(cotacao, aConverter).ToString("F2", CultureInfo.InvariantCulture)}");
    }
  }
}