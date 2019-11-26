using System;

namespace AbstractClass
{
  class Program
  {
    static void Main(string[] args)
    {
      Programador objProgramador = new Programador();
      Designer objDesigner = new Designer();

      objProgramador.Salario = 1300M;
      Console.WriteLine("Calculando o reajuste de Programador\n");
      objProgramador.Reajustar();

      Console.WriteLine("Novo salário é: " + objProgramador.Salario);

      objDesigner.Salario = 1100M;
      Console.WriteLine("\n Calculando Reajuste de Designer\n");
      objDesigner.Reajustar();
      Console.WriteLine("Novo salário é: " + objDesigner.Salario);

      Console.ReadKey();
    }
  }
}
