using System;
using System.Globalization;

namespace Execs
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Pessoas pessoas = new Pessoas();
      // Console.WriteLine("Dados da primeira pessoa:");
      // Console.Write("Nome: ");
      // pessoas.Nome1 = Console.ReadLine();
      // Console.Write("Idade: ");
      // pessoas.Idade1 = int.Parse(Console.ReadLine());

      // Console.WriteLine("Dados da segunda pessoa:");
      // Console.Write("Nome: ");
      // pessoas.Nome2 = Console.ReadLine();
      // Console.Write("Idade: ");
      // pessoas.Idade2 = int.Parse(Console.ReadLine());

      // pessoas.PessoaMaisVelha();

      Funcionario funcionario1 = new Funcionario();
      Console.WriteLine("Dados do primeiro funcionário:");
      Console.Write("Nome: ");
      funcionario1.Nome1 = Console.ReadLine();
      Console.Write("Salário: ");
      funcionario1.Idade1 = int.Parse(Console.ReadLine());

      Funcionario funcionario2 = new Funcionario();
      Console.WriteLine("Dados do segundo funcionário:");
      Console.Write("Nome: ");
      funcionario2.Nome2 = Console.ReadLine();
      Console.Write("Salário: ");
      funcionario2.Idade2 = int.Parse(Console.ReadLine());

      double media = (funcionario1.Salario + funcionario1.Salario) / 2;
      Console.WriteLine($"Salário médio = {media}");

    }
  }
}