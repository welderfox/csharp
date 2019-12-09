using System;
using System.Globalization;

namespace Execs
{
  class Program
  {
    public static void Main(string[] args)
    {
      Aluno a = new Aluno();
      Console.Write("Nome do aluno: ");
      a.Nome = Console.ReadLine();
      Console.WriteLine("Digite as três notas do aluno: ");
      a.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      a.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      a.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.WriteLine(a.ToString());
    }
  }
}