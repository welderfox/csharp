using System;
using System.Globalization;

namespace Execs
{
  class Program
  {
    public static void Main(string[] args)
    {
      int numero;
      string proprietario;
      char resposta;
      double saldoInicial, deposito, saque;
      ContaBancaria nova;
      Console.Write("Entre o número da conta: ");
      numero = int.Parse(Console.ReadLine());
      Console.Write("Entre o titular da conta: ");
      proprietario = Console.ReadLine();
      Console.Write("Haverá valor de depósito inicial (s/n)? ");
      resposta = char.Parse(Console.ReadLine());
      if (resposta == 's' || resposta == 'S')
      {
        Console.Write("Entre o valor de depósito inicial: ");
        saldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        nova = new ContaBancaria(numero, proprietario, saldoInicial);
      }
      else
      {
        nova = new ContaBancaria(numero, proprietario);
      }

      Console.WriteLine("Dados da conta:");
      Console.WriteLine(nova);
      Console.Write("Entre um valor para depósito: ");
      deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      nova.Deposito(deposito);
      Console.WriteLine("Dados da conta atualizados:");
      Console.WriteLine(nova);
      Console.Write("Entre um valor para saque: ");
      saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      nova.Saque(saque);
      Console.WriteLine("Dados da conta atualizados:");
      Console.WriteLine(nova);
    }
  }
}